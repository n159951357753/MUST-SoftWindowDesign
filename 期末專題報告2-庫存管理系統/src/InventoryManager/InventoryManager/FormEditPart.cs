using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class FormEditPart : Form
    {
        public FormEditPart()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<tabControlMain.StockHistoryEntry> HistoryList { get; set; }

        public tabControlMain.Part EditedPart
        {
            get
            {
                return new tabControlMain.Part
                {
                    PartNumber = txtPartNumber.Text,
                    PartName = txtPartName.Text,
                    StorageLocation = txtLocation.Text,
                    Quantity = (int)numQuantity.Value,
                    LowerLimit = (int)numLowerLimit.Value,
                    UpperLimit = (int)numUpperLimit.Value,
                    Note = txtNote.Text
                };
            }
            set
            {
                txtPartNumber.Text = value.PartNumber;
                txtPartName.Text = value.PartName;
                txtLocation.Text = value.StorageLocation;

                numQuantity.Minimum = 0;
                numQuantity.Maximum = Math.Max(10000, value.Quantity);
                numQuantity.Value = value.Quantity;

                numLowerLimit.Minimum = 0;
                numLowerLimit.Maximum = Math.Max(10000, value.LowerLimit);
                numLowerLimit.Value = value.LowerLimit;

                numUpperLimit.Minimum = 0;
                numUpperLimit.Maximum = Math.Max(10000, value.UpperLimit);
                numUpperLimit.Value = value.UpperLimit;

                txtNote.Text = value.Note;

                LoadPartHistory(value.PartNumber);
            }

        }



        private void LoadPartHistory(string partNumber)
        {
            if (HistoryList == null) return;

            var filtered = HistoryList
                .Where(h => h.PartNumber == partNumber)
                .OrderByDescending(h => h.Timestamp)
                .ToList();

            dgvHistoryPart.DataSource = null;           // 清除前一筆
            dgvHistoryPart.AutoGenerateColumns = false; // 使用 Designer 設定的欄位
            dgvHistoryPart.DataSource = filtered;       // 直接套用物件清單
        }


        private void SetupHistoryGrid()
        {
            dgvHistoryPart.Columns.Clear();
            dgvHistoryPart.AutoGenerateColumns = false;

            dgvHistoryPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Timestamp",
                HeaderText = "時間",
                Width = 150
            });

            dgvHistoryPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OperationType",
                HeaderText = "操作類型",
                Width = 100
            });

            dgvHistoryPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityChanged",
                HeaderText = "數量變動",
                Width = 100
            });

            dgvHistoryPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Operator",
                HeaderText = "操作人",
                Width = 100
            });

            dgvHistoryPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Note",
                HeaderText = "備註",
                Width = 600
            });

            dgvHistoryPart.AllowUserToAddRows = false;
            dgvHistoryPart.ReadOnly = true;
        }



        private void FormEditPart_Load(object sender, EventArgs e)
        {


            //SetupHistoryGrid();

            // 綁定資料欄位名稱（DataPropertyName）
            Timestamp.DataPropertyName = "Timestamp";
            OperationType.DataPropertyName = "OperationType";
            QuantityChanged.DataPropertyName = "QuantityChanged";
            Operator.DataPropertyName = "Operator";
            Note.DataPropertyName = "Note";
        }

        private void numUpperLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvHistoryPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
