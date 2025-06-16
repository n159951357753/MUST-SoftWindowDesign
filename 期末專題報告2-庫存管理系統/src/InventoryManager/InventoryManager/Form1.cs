using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;



namespace InventoryManager
{
    public partial class tabControlMain : Form
    {
        public tabControlMain()
        {
            InitializeComponent();
        }






        private const string PartsJsonPath = "parts.json";
        private const string HistoryJsonPath = "history.json";

        private List<Part> parts = new List<Part>();
        private List<StockHistoryEntry> history = new List<StockHistoryEntry>();

        public class StockHistoryEntry
        {
            public DateTime Timestamp { get; set; }
            public string PartNumber { get; set; }
            public string OperationType { get; set; } // "入庫" or "出庫"
            public int QuantityChanged { get; set; }
            public string Operator { get; set; }
            public string Note { get; set; }
        }

        private void LoadData()
        {
            if (File.Exists(PartsJsonPath))
                parts = JsonSerializer.Deserialize<List<Part>>(File.ReadAllText(PartsJsonPath));
            else
                parts = GetMockParts();

            if (File.Exists(HistoryJsonPath))
                history = JsonSerializer.Deserialize<List<StockHistoryEntry>>(File.ReadAllText(HistoryJsonPath));
            else
                history = new List<StockHistoryEntry>();
        }

        private void SaveData()
        {
            File.WriteAllText(PartsJsonPath, JsonSerializer.Serialize(parts, new JsonSerializerOptions { WriteIndented = true }));
            File.WriteAllText(HistoryJsonPath, JsonSerializer.Serialize(history, new JsonSerializerOptions { WriteIndented = true }));
        }

        private void BindData()
        {
            dgvParts.DataSource = null;
            dgvParts.DataSource = parts;

            dgvLowStock.DataSource = parts.Where(p => p.Quantity < p.LowerLimit).ToList();

            dgvRecentTransactions.DataSource = history
                .OrderByDescending(h => h.Timestamp)
                .Take(20)
                .ToList();

            dgvHistory.DataSource = history.OrderByDescending(h => h.Timestamp).ToList();
        }








        private void dgvParts_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvParts.IsCurrentCellDirty)
                dgvParts.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvParts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParts.Columns[e.ColumnIndex].Name == "chkSelect")
            {
                bool checkedVal = Convert.ToBoolean(dgvParts.Rows[e.RowIndex].Cells["chkSelect"].Value);
                if (checkedVal)
                {
                    for (int i = 0; i < dgvParts.Rows.Count; i++)
                    {
                        if (i != e.RowIndex)
                            dgvParts.Rows[i].Cells["chkSelect"].Value = false;
                    }
                }
            }
        }


        private void btnAddPart_Click(object sender, EventArgs e)
        {
            FormAddPart form = new FormAddPart();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var newPart = form.NewPart;
                var list = dgvParts.DataSource as List<Part>;
                if (list == null)
                {
                    MessageBox.Show("無法取得資料來源");
                    return;
                }

                // 檢查是否已存在相同編號
                if (list.Any(p => p.PartNumber == newPart.PartNumber))
                {
                    MessageBox.Show("已有相同零件編號，請使用不同編號", "重複編號", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 加入資料並刷新 DataGridView
                list.Add(newPart);
                dgvParts.DataSource = null;
                dgvParts.DataSource = list;

                MessageBox.Show("新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEditPart_Click(object sender, EventArgs e)
        {
            var list = dgvParts.DataSource as List<Part>;
            if (list == null) return;

            var selectedRow = dgvParts.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => Convert.ToBoolean(row.Cells["chkSelect"].Value));

            if (selectedRow == null)
            {
                MessageBox.Show("請先勾選一筆零件進行編輯");
                return;
            }

            string partNumber = selectedRow.Cells["PartNumber"].Value.ToString();
            Part part = list.FirstOrDefault(p => p.PartNumber == partNumber);
            if (part == null) return;

            FormEditPart form = new FormEditPart();

            // 填入現有資料
            form.EditedPart = part;  // 填入資料

            if (form.ShowDialog() == DialogResult.OK)
            {
                Part updated = form.EditedPart;
                part.PartName = updated.PartName;
                part.StorageLocation = updated.StorageLocation;
                part.Quantity = updated.Quantity;
                part.LowerLimit = updated.LowerLimit;
                part.UpperLimit = updated.UpperLimit;
                part.Note = updated.Note;
                dgvParts.Refresh();

                history.Add(new StockHistoryEntry
                {
                    Timestamp = DateTime.Now,
                    PartNumber = part.PartNumber,
                    OperationType = "人工編輯",
                    QuantityChanged = updated.Quantity,
                    Operator = Environment.UserName,
                    Note = updated.Note
                });
                SaveData();
                BindData();

                MessageBox.Show("儲存成功！");
            }

        }


        private void btnStockIn_Click(object sender, EventArgs e)
        {
            var list = dgvParts.DataSource as List<Part>;
            if (list == null) return;

            var selectedRow = dgvParts.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => Convert.ToBoolean(row.Cells["chkSelect"].Value));

            if (selectedRow == null)
            {
                MessageBox.Show("請先勾選一筆零件進行入庫");
                return;
            }

            string partNumber = selectedRow.Cells["PartNumber"].Value.ToString();
            Part part = list.FirstOrDefault(p => p.PartNumber == partNumber);
            if (part == null) return;

            FormStockInEdit form = new FormStockInEdit();
            form.PartNumberText = part.PartNumber;
            form.PartNameText = part.PartName;
            form.CurrentQtyText = part.Quantity.ToString();

            if (form.ShowDialog() == DialogResult.OK)
            {
                part.Quantity += form.StockInAmount;
                part.Note += $" [入庫+{form.StockInAmount}]";
                dgvParts.Refresh();

                history.Add(new StockHistoryEntry
                {
                    Timestamp = DateTime.Now,
                    PartNumber = part.PartNumber,
                    OperationType = "入庫",
                    QuantityChanged = form.StockInAmount,
                    Operator = Environment.UserName,
                    Note = form.StockInNote
                });
                SaveData();
                BindData();


                MessageBox.Show("入庫成功！");
            }

        }


        private void btnStockOut_Click(object sender, EventArgs e)
        {
            var list = dgvParts.DataSource as List<Part>;
            if (list == null) return;

            var selectedRow = dgvParts.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => Convert.ToBoolean(row.Cells["chkSelect"].Value));

            if (selectedRow == null)
            {
                MessageBox.Show("請先勾選一筆零件進行出庫");
                return;
            }

            string partNumber = selectedRow.Cells["PartNumber"].Value.ToString();
            Part part = list.FirstOrDefault(p => p.PartNumber == partNumber);
            if (part == null) return;

            FormStockOutEdit form = new FormStockOutEdit();
            form.PartNumberText = part.PartNumber;
            form.PartNameText = part.PartName;
            form.CurrentQtyText = part.Quantity.ToString();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.StockOutAmount > part.Quantity)
                {
                    MessageBox.Show("出庫數量超過現有庫存，操作取消", "庫存不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                part.Quantity -= form.StockOutAmount;
                part.Note += $" [出庫-{form.StockOutAmount}]";
                dgvParts.Refresh();

                history.Add(new StockHistoryEntry
                {
                    Timestamp = DateTime.Now,
                    PartNumber = part.PartNumber,
                    OperationType = "出庫",
                    QuantityChanged = -form.StockOutAmount,
                    Operator = Environment.UserName,
                    Note = form.StockOutNote
                });
                SaveData();
                BindData();

                MessageBox.Show("出庫成功！");
            }

        }





        private void txtSearchKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabControlMain_Load(object sender, EventArgs e)
        {

            

            // 註冊事件（限制只能勾選一筆）
            dgvParts.CellValueChanged += dgvParts_CellValueChanged;
            dgvParts.CurrentCellDirtyStateChanged += dgvParts_CurrentCellDirtyStateChanged;

            // 資料欄位對應
            PartNumber.DataPropertyName = "PartNumber";
            PartName.DataPropertyName = "PartName";
            StorageLocation.DataPropertyName = "StorageLocation";
            Quantity.DataPropertyName = "Quantity";
            LowerLimit.DataPropertyName = "LowerLimit";
            UpperLimit.DataPropertyName = "UpperLimit";
            Note.DataPropertyName = "Note";

            LoadData();
            BindData();


        }














        public class Part
        {
            public string PartNumber { get; set; }
            public string PartName { get; set; }
            public string StorageLocation { get; set; }
            public int Quantity { get; set; }
            public int LowerLimit { get; set; }
            public int UpperLimit { get; set; }
            public string Note { get; set; }
        }

        private List<Part> GetMockParts()
        {
            return new List<Part>
            {
                new Part { PartNumber = "A001", PartName = "螺絲", StorageLocation = "櫃1", Quantity = 100, LowerLimit = 20, UpperLimit = 200, Note = "測試用" },
                new Part { PartNumber = "B002", PartName = "墊片", StorageLocation = "櫃2", Quantity = 50, LowerLimit = 10, UpperLimit = 150, Note = "" },
                new Part { PartNumber = "C003", PartName = "墊片", StorageLocation = "櫃2", Quantity = 20, LowerLimit = 5, UpperLimit = 180, Note = "" },
                new Part { PartNumber = "D004", PartName = "墊片", StorageLocation = "櫃2", Quantity = 60, LowerLimit = 10, UpperLimit = 300, Note = "" }
            };
        }



    }
}
