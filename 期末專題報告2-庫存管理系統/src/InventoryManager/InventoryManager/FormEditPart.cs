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
            }

        }


        private void FormEditPart_Load(object sender, EventArgs e)
        {

        }
    }
}
