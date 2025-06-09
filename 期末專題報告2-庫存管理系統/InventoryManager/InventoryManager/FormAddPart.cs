using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InventoryManager.tabControlMain;

namespace InventoryManager
{
    public partial class FormAddPart : Form
    {
        public FormAddPart()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // 檢查基本欄位
            if (string.IsNullOrWhiteSpace(txtPartNumber.Text) ||
                string.IsNullOrWhiteSpace(txtPartName.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("請填寫所有必填欄位（零件編號、名稱、存放位置）", "欄位不完整", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 這裡不直接檢查重複，由主畫面處理

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Part NewPart
        {
            get
            {
                return new Part
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
        }


        private void FormAddPart_Load(object sender, EventArgs e)
        {

        }
    }
}
