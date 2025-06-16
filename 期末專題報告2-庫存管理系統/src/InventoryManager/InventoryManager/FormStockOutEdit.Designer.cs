namespace InventoryManager
{
    partial class FormStockOutEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupPartInfo = new System.Windows.Forms.GroupBox();
            this.groupOperation = new System.Windows.Forms.GroupBox();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblCurrentQty = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupPartInfo.SuspendLayout();
            this.groupOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPartInfo
            // 
            this.groupPartInfo.Controls.Add(this.txtCurrentQty);
            this.groupPartInfo.Controls.Add(this.lblPartNumber);
            this.groupPartInfo.Controls.Add(this.lblCurrentQty);
            this.groupPartInfo.Controls.Add(this.txtPartName);
            this.groupPartInfo.Controls.Add(this.txtPartNumber);
            this.groupPartInfo.Controls.Add(this.lblPartName);
            this.groupPartInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupPartInfo.Location = new System.Drawing.Point(62, 23);
            this.groupPartInfo.Name = "groupPartInfo";
            this.groupPartInfo.Size = new System.Drawing.Size(459, 179);
            this.groupPartInfo.TabIndex = 0;
            this.groupPartInfo.TabStop = false;
            this.groupPartInfo.Text = "零件資訊";
            // 
            // groupOperation
            // 
            this.groupOperation.Controls.Add(this.lblAmount);
            this.groupOperation.Controls.Add(this.lblNote);
            this.groupOperation.Controls.Add(this.txtNote);
            this.groupOperation.Controls.Add(this.numAmount);
            this.groupOperation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupOperation.Location = new System.Drawing.Point(62, 208);
            this.groupOperation.Name = "groupOperation";
            this.groupOperation.Size = new System.Drawing.Size(459, 240);
            this.groupOperation.TabIndex = 1;
            this.groupOperation.TabStop = false;
            this.groupOperation.Text = "操作內容";
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentQty.Location = new System.Drawing.Point(190, 116);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.ReadOnly = true;
            this.txtCurrentQty.Size = new System.Drawing.Size(172, 31);
            this.txtCurrentQty.TabIndex = 31;
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartName.Location = new System.Drawing.Point(190, 79);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.ReadOnly = true;
            this.txtPartName.Size = new System.Drawing.Size(172, 31);
            this.txtPartName.TabIndex = 30;
            // 
            // lblCurrentQty
            // 
            this.lblCurrentQty.AutoSize = true;
            this.lblCurrentQty.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCurrentQty.Location = new System.Drawing.Point(75, 121);
            this.lblCurrentQty.Name = "lblCurrentQty";
            this.lblCurrentQty.Size = new System.Drawing.Size(89, 20);
            this.lblCurrentQty.TabIndex = 29;
            this.lblCurrentQty.Text = "當前庫存";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPartName.Location = new System.Drawing.Point(75, 84);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(89, 20);
            this.lblPartName.TabIndex = 28;
            this.lblPartName.Text = "零件名稱\n";
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPartNumber.Location = new System.Drawing.Point(75, 47);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(89, 20);
            this.lblPartNumber.TabIndex = 27;
            this.lblPartNumber.Text = "零件編號";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartNumber.Location = new System.Drawing.Point(190, 42);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.ReadOnly = true;
            this.txtPartNumber.Size = new System.Drawing.Size(172, 31);
            this.txtPartNumber.TabIndex = 26;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(118, 40);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(120, 31);
            this.numAmount.TabIndex = 0;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(61, 79);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(380, 144);
            this.txtNote.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmount.Location = new System.Drawing.Point(6, 45);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 20);
            this.lblAmount.TabIndex = 29;
            this.lblAmount.Text = "出庫數量";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNote.Location = new System.Drawing.Point(6, 79);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(49, 20);
            this.lblNote.TabIndex = 30;
            this.lblNote.Text = "備註";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWarning.Location = new System.Drawing.Point(84, 460);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 20);
            this.lblWarning.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(83, 493);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(165, 43);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(335, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 43);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormStockOutEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.groupOperation);
            this.Controls.Add(this.groupPartInfo);
            this.Name = "FormStockOutEdit";
            this.Text = "FormStockOutEdit";
            this.Load += new System.EventHandler(this.FormStockOutEdit_Load);
            this.groupPartInfo.ResumeLayout(false);
            this.groupPartInfo.PerformLayout();
            this.groupOperation.ResumeLayout(false);
            this.groupOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPartInfo;
        private System.Windows.Forms.GroupBox groupOperation;
        private System.Windows.Forms.TextBox txtCurrentQty;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.Label lblCurrentQty;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}