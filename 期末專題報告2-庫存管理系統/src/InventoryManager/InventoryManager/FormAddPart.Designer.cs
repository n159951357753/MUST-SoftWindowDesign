namespace InventoryManager
{
    partial class FormAddPart
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.numUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.numLowerLimit = new System.Windows.Forms.NumericUpDown();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.lblLowerLimit = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupPartInfo = new System.Windows.Forms.GroupBox();
            this.label_numwarn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.groupPartInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreate.Location = new System.Drawing.Point(48, 584);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(175, 47);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "儲存新增";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // numUpperLimit
            // 
            this.numUpperLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numUpperLimit.Location = new System.Drawing.Point(229, 279);
            this.numUpperLimit.Name = "numUpperLimit";
            this.numUpperLimit.Size = new System.Drawing.Size(172, 31);
            this.numUpperLimit.TabIndex = 27;
            // 
            // numLowerLimit
            // 
            this.numLowerLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numLowerLimit.Location = new System.Drawing.Point(229, 331);
            this.numLowerLimit.Name = "numLowerLimit";
            this.numLowerLimit.Size = new System.Drawing.Size(172, 31);
            this.numLowerLimit.TabIndex = 26;
            this.numLowerLimit.ValueChanged += new System.EventHandler(this.numLowerLimit_ValueChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLocation.Location = new System.Drawing.Point(229, 175);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(172, 31);
            this.txtLocation.TabIndex = 25;
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartName.Location = new System.Drawing.Point(229, 123);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(172, 31);
            this.txtPartName.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(301, 584);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 47);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNote.Location = new System.Drawing.Point(107, 386);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(294, 127);
            this.txtNote.TabIndex = 23;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNote.Location = new System.Drawing.Point(52, 388);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(49, 20);
            this.lblNote.TabIndex = 22;
            this.lblNote.Text = "備註";
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUpperLimit.Location = new System.Drawing.Point(52, 284);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(49, 20);
            this.lblUpperLimit.TabIndex = 21;
            this.lblUpperLimit.Text = "上限";
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLowerLimit.Location = new System.Drawing.Point(52, 336);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(129, 20);
            this.lblLowerLimit.TabIndex = 20;
            this.lblLowerLimit.Text = "下限（告急）";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQuantity.Location = new System.Drawing.Point(52, 232);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(89, 20);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "當前庫存";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLocation.Location = new System.Drawing.Point(52, 180);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(89, 20);
            this.lblLocation.TabIndex = 18;
            this.lblLocation.Text = "存放位置";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPartName.Location = new System.Drawing.Point(52, 128);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(89, 20);
            this.lblPartName.TabIndex = 17;
            this.lblPartName.Text = "零件名稱\n";
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPartNumber.Location = new System.Drawing.Point(52, 37);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(89, 20);
            this.lblPartNumber.TabIndex = 16;
            this.lblPartNumber.Text = "零件編號";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartNumber.Location = new System.Drawing.Point(229, 32);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(172, 31);
            this.txtPartNumber.TabIndex = 15;
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numQuantity.Location = new System.Drawing.Point(229, 227);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(172, 31);
            this.numQuantity.TabIndex = 14;
            // 
            // groupPartInfo
            // 
            this.groupPartInfo.Controls.Add(this.label_numwarn);
            this.groupPartInfo.Controls.Add(this.numUpperLimit);
            this.groupPartInfo.Controls.Add(this.numLowerLimit);
            this.groupPartInfo.Controls.Add(this.txtLocation);
            this.groupPartInfo.Controls.Add(this.txtPartName);
            this.groupPartInfo.Controls.Add(this.txtNote);
            this.groupPartInfo.Controls.Add(this.lblNote);
            this.groupPartInfo.Controls.Add(this.lblUpperLimit);
            this.groupPartInfo.Controls.Add(this.lblLowerLimit);
            this.groupPartInfo.Controls.Add(this.lblQuantity);
            this.groupPartInfo.Controls.Add(this.lblLocation);
            this.groupPartInfo.Controls.Add(this.lblPartName);
            this.groupPartInfo.Controls.Add(this.lblPartNumber);
            this.groupPartInfo.Controls.Add(this.txtPartNumber);
            this.groupPartInfo.Controls.Add(this.numQuantity);
            this.groupPartInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupPartInfo.Location = new System.Drawing.Point(23, 12);
            this.groupPartInfo.Name = "groupPartInfo";
            this.groupPartInfo.Size = new System.Drawing.Size(478, 543);
            this.groupPartInfo.TabIndex = 18;
            this.groupPartInfo.TabStop = false;
            this.groupPartInfo.Text = "零件資訊";
            // 
            // label_numwarn
            // 
            this.label_numwarn.AutoSize = true;
            this.label_numwarn.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_numwarn.ForeColor = System.Drawing.Color.Red;
            this.label_numwarn.Location = new System.Drawing.Point(74, 70);
            this.label_numwarn.Name = "label_numwarn";
            this.label_numwarn.Size = new System.Drawing.Size(314, 34);
            this.label_numwarn.TabIndex = 28;
            this.label_numwarn.Text = "零件編號建立成功後不可編輯更改\r\n且編號具唯一性，只可透過刪除零件重建";
            this.label_numwarn.Click += new System.EventHandler(this.label_numwarn_Click);
            // 
            // FormAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 657);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupPartInfo);
            this.Name = "FormAddPart";
            this.Text = "新增零件";
            this.Load += new System.EventHandler(this.FormAddPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.groupPartInfo.ResumeLayout(false);
            this.groupPartInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown numUpperLimit;
        private System.Windows.Forms.NumericUpDown numLowerLimit;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblUpperLimit;
        private System.Windows.Forms.Label lblLowerLimit;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.GroupBox groupPartInfo;
        private System.Windows.Forms.Label label_numwarn;
    }
}