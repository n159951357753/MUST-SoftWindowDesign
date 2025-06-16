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
using static InventoryManager.tabControlMain;



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

        private string searchKeyword = "";
        private string searchField = "";

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
            ApplySearchFilter();
            SetPartsGridReadOnly();

            dgvLowStock.DataSource = parts.Where(p => p.Quantity < p.LowerLimit).ToList();

            dgvRecentTransactions.DataSource = history
                .OrderByDescending(h => h.Timestamp)
                .Take(20)
                .ToList();

            SetupHistoryGrid();

            ApplyHistoryFilter();
            //dgvHistory.DataSource = history.OrderByDescending(h => h.Timestamp).ToList();
        }


        private void ApplySearchFilter()
        {
            IEnumerable<Part> filtered = parts;

            if (!string.IsNullOrEmpty(searchKeyword) && !string.IsNullOrEmpty(searchField))
            {
                Func<Part, string> fieldSelector;

                if (searchField == "零件編號")
                    fieldSelector = p => p.PartNumber;
                else if (searchField == "零件名稱")
                    fieldSelector = p => p.PartName;
                else if (searchField == "存放位置")
                    fieldSelector = p => p.StorageLocation;
                else if (searchField == "備註")
                    fieldSelector = p => p.Note;
                else
                    fieldSelector = p => "";


                string keywordLower = searchKeyword.ToLower();
                filtered = parts.Where(p => (fieldSelector(p) ?? "").ToLower().Contains(keywordLower));
            }

            dgvParts.DataSource = null;
            dgvParts.DataSource = filtered.ToList();
            SetPartsGridReadOnly();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchKeyword = txtSearchKeyword.Text.Trim();
            searchField = cmbSearchField.SelectedItem?.ToString() ?? "";
            ApplySearchFilter();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            searchKeyword = "";
            searchField = "";
            txtSearchKeyword.Text = "";
            //cmbSearchField.SelectedIndex = 1;
            ApplySearchFilter();
        }



        private void SetupHistoryGrid()
        {
            dgvHistory.AutoGenerateColumns = false; // 禁用自動產生欄位
            dgvHistory.Columns.Clear();

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Timestamp",
                HeaderText = "時間",
                DataPropertyName = "Timestamp",
                Width = 150,
                ReadOnly = true
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PartNumber",
                HeaderText = "零件編號",
                DataPropertyName = "PartNumber",
                Width = 100,
                ReadOnly = true
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OperationType",
                HeaderText = "操作類型",
                DataPropertyName = "OperationType",
                Width = 100,
                ReadOnly = true
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityChanged",
                HeaderText = "數量變動",
                DataPropertyName = "QuantityChanged",
                Width = 100,
                ReadOnly = true
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Operator",
                HeaderText = "操作者",
                DataPropertyName = "Operator",
                Width = 100,
                ReadOnly = true
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Note",
                HeaderText = "備註",
                DataPropertyName = "Note",
                Width = 1000,
                ReadOnly = true
            });
        }




        private void SetPartsGridReadOnly()
        {
            foreach (DataGridViewColumn col in dgvParts.Columns)
            {
                // 只讓勾選欄可以編輯，其餘設為唯讀
                col.ReadOnly = (col.Name != "chkSelect");

                // 根據 Designer 初始設定還原欄寬
                switch (col.Name)
                {
                    case "chkSelect":
                        col.HeaderText = "勾選框";
                        col.Width = 80;
                        break;
                    case "PartNumber":
                        col.HeaderText = "零件編號";
                        col.Width = 125;
                        break;
                    case "PartName":
                        col.HeaderText = "零件名稱";
                        col.Width = 125;
                        break;
                    case "StorageLocation":
                        col.HeaderText = "存放位置";
                        col.Width = 125;
                        break;
                    case "Quantity":
                        col.HeaderText = "當前庫存";
                        col.Width = 120;
                        break;
                    case "LowerLimit":
                        col.HeaderText = "下限";
                        col.Width = 80;
                        break;
                    case "UpperLimit":
                        col.HeaderText = "上限";
                        col.Width = 80;
                        break;
                    case "Note":
                        col.HeaderText = "備註";
                        col.Width = 125;
                        break;
                }
            }
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


                // 使用真正的資料來源
                if (parts.Any(p => p.PartNumber == newPart.PartNumber))
                {
                    MessageBox.Show("已有相同零件編號，請使用不同編號", "重複編號", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                parts.Add(newPart); // 加入真正的資料來源

                // 新增紀錄到歷史紀錄
                history.Add(new StockHistoryEntry
                {
                    Timestamp = DateTime.Now,
                    PartNumber = newPart.PartNumber,
                    OperationType = "新增零件",
                    QuantityChanged = newPart.Quantity,
                    Operator = Environment.UserName,
                    Note = $"新增:{newPart.PartName}"
                });

                
                SaveData();
                BindData();

                MessageBox.Show("新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEditPart_Click(object sender, EventArgs e)
        {

            var selectedRow = dgvParts.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => Convert.ToBoolean(row.Cells["chkSelect"].Value));

            if (selectedRow == null)
            {
                MessageBox.Show("請先勾選一筆零件進行編輯");
                return;
            }

            string partNumber = selectedRow.Cells["PartNumber"].Value.ToString();
            Part part = parts.FirstOrDefault(p => p.PartNumber == partNumber);
            if (part == null) return;

            FormEditPart form = new FormEditPart();
            
            form.HistoryList = history; //傳入完整歷史紀錄
            form.EditedPart = part;  // 填入現有資料


            if (form.ShowDialog() == DialogResult.OK)
            {
                Part updated = form.EditedPart;

                // 組合變更內容的描述字串
                List<string> changeNotes = new List<string>();
                if (part.PartName != updated.PartName)
                    changeNotes.Add($"零件名稱[{part.PartName}->{updated.PartName}]");
                if (part.StorageLocation != updated.StorageLocation)
                    changeNotes.Add($"儲位[{part.StorageLocation}->{updated.StorageLocation}]");
                if (part.Quantity != updated.Quantity)
                    changeNotes.Add($"庫存[{part.Quantity}->{updated.Quantity}]");
                if (part.LowerLimit != updated.LowerLimit)
                    changeNotes.Add($"告急量[{part.LowerLimit}->{updated.LowerLimit}]");
                if (part.UpperLimit != updated.UpperLimit)
                    changeNotes.Add($"上限[{part.UpperLimit}->{updated.UpperLimit}]");
                if (part.Note != updated.Note)
                    changeNotes.Add($"備註[{part.Note}->{updated.Note}]");

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
                    Note = string.Join("  ", changeNotes)
                });

                SaveData();
                BindData();

                MessageBox.Show("儲存成功！");
            }

        }




        private void btnDeletePart_Click(object sender, EventArgs e)
        {

            var selectedRow = dgvParts.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => Convert.ToBoolean(row.Cells["chkSelect"].Value));

            if (selectedRow == null)
            {
                MessageBox.Show("請先勾選一筆零件進行刪除");
                return;
            }

            string partNumber = selectedRow.Cells["PartNumber"].Value.ToString();
            Part part = parts.FirstOrDefault(p => p.PartNumber == partNumber);
            if (part == null) return;

            var result = MessageBox.Show($"確定要刪除零件：{part.PartName} ({part.PartNumber})？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                parts.Remove(part);

                history.Add(new StockHistoryEntry
                {
                    Timestamp = DateTime.Now,
                    PartNumber = part.PartNumber,
                    OperationType = "刪除零件",
                    QuantityChanged = 0,
                    Operator = Environment.UserName,
                    Note = $"刪除：{part.PartName}"
                });

                SaveData();
                BindData();

                MessageBox.Show("刪除成功！");
            }
        }






        private void btnStockIn_Click(object sender, EventArgs e)
        {

            var selectedRow = dgvParts.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => Convert.ToBoolean(row.Cells["chkSelect"].Value));

            if (selectedRow == null)
            {
                MessageBox.Show("請先勾選一筆零件進行入庫");
                return;
            }

            string partNumber = selectedRow.Cells["PartNumber"].Value.ToString();
            Part part = parts.FirstOrDefault(p => p.PartNumber == partNumber);
            if (part == null) return;

            FormStockInEdit form = new FormStockInEdit();
            form.PartNumberText = part.PartNumber;
            form.PartNameText = part.PartName;
            form.CurrentQtyText = part.Quantity.ToString();

            if (form.ShowDialog() == DialogResult.OK)
            {
                part.Quantity += form.StockInAmount;
                //part.Note += $" [入庫+{form.StockInAmount}]";
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

            var selectedRow = dgvParts.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => Convert.ToBoolean(row.Cells["chkSelect"].Value));

            if (selectedRow == null)
            {
                MessageBox.Show("請先勾選一筆零件進行出庫");
                return;
            }

            string partNumber = selectedRow.Cells["PartNumber"].Value.ToString();
            Part part = parts.FirstOrDefault(p => p.PartNumber == partNumber);

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
                //part.Note += $" [出庫-{form.StockOutAmount}]";
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




        private void ApplyHistoryFilter()
        {
            string keyword = txtKeywordHistory.Text.Trim().ToLower();
            DateTime start = dtStartHistory.Value.Date;
            DateTime end = dtEndHistory.Value.Date.AddDays(1); // 包含當天整天

            IEnumerable<StockHistoryEntry> filtered = history;

            if (!string.IsNullOrEmpty(keyword))
            {
                filtered = filtered.Where(h =>
                    (h.PartNumber?.ToLower().Contains(keyword) ?? false) ||
                    (h.OperationType?.ToLower().Contains(keyword) ?? false) ||
                    (h.Operator?.ToLower().Contains(keyword) ?? false) ||
                    (h.Note?.ToLower().Contains(keyword) ?? false));
            }

            filtered = filtered.Where(h => h.Timestamp >= start && h.Timestamp < end);

            dgvHistory.DataSource = null;
            dgvHistory.DataSource = filtered.OrderByDescending(h => h.Timestamp).ToList();
        }

        private void ClearHistoryFilter()
        {
            dgvHistory.DataSource = null;
            dgvHistory.DataSource = history.OrderByDescending(h => h.Timestamp).ToList();
        }


        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            ApplyHistoryFilter();
        }

        private void btnSearchHistoryClear_Click(object sender, EventArgs e)
        {
            txtKeywordHistory.Text = "";
            //dtStartHistory.Value = DateTime.Today.AddMonths(-1);
            dtStartHistory.Value = DateTime.Today;
            dtEndHistory.Value = DateTime.Today;
            ApplyHistoryFilter();
        }

        private void btnSearchHistoryCancel_Click(object sender, EventArgs e)
        {
            ClearHistoryFilter();
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

            SetupHistoryGrid();

            cmbSearchField.Items.AddRange(new string[] { "零件編號", "零件名稱", "存放位置", "備註" });
            cmbSearchField.SelectedIndex = 1;

            LoadData();
            BindData();

            ClearHistoryFilter();

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
