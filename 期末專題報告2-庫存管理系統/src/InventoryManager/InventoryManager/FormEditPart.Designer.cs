namespace InventoryManager
{
    partial class FormEditPart
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
            this.groupHistory = new System.Windows.Forms.GroupBox();
            this.numUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.numLowerLimit = new System.Windows.Forms.NumericUpDown();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPartInfo.SuspendLayout();
            this.groupHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPartInfo
            // 
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
            this.groupPartInfo.Location = new System.Drawing.Point(12, 12);
            this.groupPartInfo.Name = "groupPartInfo";
            this.groupPartInfo.Size = new System.Drawing.Size(399, 543);
            this.groupPartInfo.TabIndex = 14;
            this.groupPartInfo.TabStop = false;
            this.groupPartInfo.Text = "零件資訊";
            // 
            // groupHistory
            // 
            this.groupHistory.Controls.Add(this.dataGridView1);
            this.groupHistory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupHistory.Location = new System.Drawing.Point(417, 12);
            this.groupHistory.Name = "groupHistory";
            this.groupHistory.Size = new System.Drawing.Size(600, 543);
            this.groupHistory.TabIndex = 15;
            this.groupHistory.TabStop = false;
            this.groupHistory.Text = "進出庫紀錄";
            // 
            // numUpperLimit
            // 
            this.numUpperLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numUpperLimit.Location = new System.Drawing.Point(199, 292);
            this.numUpperLimit.Name = "numUpperLimit";
            this.numUpperLimit.Size = new System.Drawing.Size(172, 31);
            this.numUpperLimit.TabIndex = 27;
            // 
            // numLowerLimit
            // 
            this.numLowerLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numLowerLimit.Location = new System.Drawing.Point(199, 240);
            this.numLowerLimit.Name = "numLowerLimit";
            this.numLowerLimit.Size = new System.Drawing.Size(172, 31);
            this.numLowerLimit.TabIndex = 26;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLocation.Location = new System.Drawing.Point(199, 136);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(172, 31);
            this.txtLocation.TabIndex = 25;
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartName.Location = new System.Drawing.Point(199, 84);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(172, 31);
            this.txtPartName.TabIndex = 24;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNote.Location = new System.Drawing.Point(77, 347);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(294, 180);
            this.txtNote.TabIndex = 23;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNote.Location = new System.Drawing.Point(22, 349);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(49, 20);
            this.lblNote.TabIndex = 22;
            this.lblNote.Text = "備註";
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUpperLimit.Location = new System.Drawing.Point(22, 245);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(49, 20);
            this.lblUpperLimit.TabIndex = 21;
            this.lblUpperLimit.Text = "上限";
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLowerLimit.Location = new System.Drawing.Point(22, 297);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(129, 20);
            this.lblLowerLimit.TabIndex = 20;
            this.lblLowerLimit.Text = "下限（告急）";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQuantity.Location = new System.Drawing.Point(22, 193);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(89, 20);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "當前庫存";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLocation.Location = new System.Drawing.Point(22, 141);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(89, 20);
            this.lblLocation.TabIndex = 18;
            this.lblLocation.Text = "存放位置";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPartName.Location = new System.Drawing.Point(22, 89);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(89, 20);
            this.lblPartName.TabIndex = 17;
            this.lblPartName.Text = "零件名稱\n";
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPartNumber.Location = new System.Drawing.Point(22, 37);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(89, 20);
            this.lblPartNumber.TabIndex = 16;
            this.lblPartNumber.Text = "零件編號";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartNumber.Location = new System.Drawing.Point(199, 32);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(172, 31);
            this.txtPartNumber.TabIndex = 15;
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numQuantity.Location = new System.Drawing.Point(199, 188);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(172, 31);
            this.numQuantity.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(605, 574);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(241, 47);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "關閉視窗不儲存";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(183, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(241, 47);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "儲存變更";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(588, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "日期";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "類型";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "數量";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "操作人員";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // FormEditPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 633);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupHistory);
            this.Controls.Add(this.groupPartInfo);
            this.Name = "FormEditPart";
            this.Text = "編輯零件資訊";
            this.Load += new System.EventHandler(this.FormEditPart_Load);
            this.groupPartInfo.ResumeLayout(false);
            this.groupPartInfo.PerformLayout();
            this.groupHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPartInfo;
        private System.Windows.Forms.GroupBox groupHistory;
        private System.Windows.Forms.NumericUpDown numUpperLimit;
        private System.Windows.Forms.NumericUpDown numLowerLimit;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtPartName;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}