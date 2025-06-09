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
    public partial class FormStockOutEdit : Form
    {
        public FormStockOutEdit()
        {
            InitializeComponent();
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


        public int StockOutAmount => (int)numAmount.Value;
        public string StockOutNote => txtNote.Text;


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




        private void FormStockOutEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
