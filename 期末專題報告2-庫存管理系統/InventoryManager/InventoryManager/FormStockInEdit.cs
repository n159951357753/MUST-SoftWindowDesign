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
    public partial class FormStockInEdit : Form
    {
        public FormStockInEdit()
        {
            InitializeComponent();
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public int StockInAmount => (int)numAmount.Value;
        public string StockInNote => txtNote.Text;

        public string PartNumberText
        {
            set => txtPartNumber.Text = value;
        }

        public string PartNameText
        {
            set => txtPartName.Text = value;
        }

        public string CurrentQtyText
        {
            set => txtCurrentQty.Text = value;
        }




        private void FormStockInEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
