namespace InventoryManager
{
    partial class tabControlMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRecentTransactions = new System.Windows.Forms.DataGridView();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.btnEditPart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.lblSearchCount = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.cmbSearchField = new System.Windows.Forms.ComboBox();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnSearchHistory = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.txtKeywordHistory = new System.Windows.Forms.TextBox();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).BeginInit();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOverview);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1321, 774);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.groupBox2);
            this.tabOverview.Controls.Add(this.groupBox1);
            this.tabOverview.Location = new System.Drawing.Point(4, 30);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(1313, 740);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "    庫存總覽    ";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLowStock);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(659, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 685);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "告急零件資訊";
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.Location = new System.Drawing.Point(15, 40);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.RowHeadersWidth = 51;
            this.dgvLowStock.RowTemplate.Height = 27;
            this.dgvLowStock.Size = new System.Drawing.Size(606, 631);
            this.dgvLowStock.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRecentTransactions);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(26, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 685);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "最近20筆進出庫紀錄";
            // 
            // dgvRecentTransactions
            // 
            this.dgvRecentTransactions.AllowUserToAddRows = false;
            this.dgvRecentTransactions.AllowUserToDeleteRows = false;
            this.dgvRecentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentTransactions.Location = new System.Drawing.Point(15, 40);
            this.dgvRecentTransactions.Name = "dgvRecentTransactions";
            this.dgvRecentTransactions.ReadOnly = true;
            this.dgvRecentTransactions.RowHeadersWidth = 51;
            this.dgvRecentTransactions.RowTemplate.Height = 27;
            this.dgvRecentTransactions.Size = new System.Drawing.Size(590, 631);
            this.dgvRecentTransactions.TabIndex = 0;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.btnEditPart);
            this.tabInventory.Controls.Add(this.label4);
            this.tabInventory.Controls.Add(this.btnStockOut);
            this.tabInventory.Controls.Add(this.btnStockIn);
            this.tabInventory.Controls.Add(this.btnDeletePart);
            this.tabInventory.Controls.Add(this.btnAddPart);
            this.tabInventory.Controls.Add(this.dgvParts);
            this.tabInventory.Controls.Add(this.lblSearchCount);
            this.tabInventory.Controls.Add(this.btnNext);
            this.tabInventory.Controls.Add(this.btnPrev);
            this.tabInventory.Controls.Add(this.cmbSearchField);
            this.tabInventory.Controls.Add(this.txtSearchKeyword);
            this.tabInventory.Location = new System.Drawing.Point(4, 30);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(1313, 740);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "    庫存管理    ";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnEditPart
            // 
            this.btnEditPart.Location = new System.Drawing.Point(62, 674);
            this.btnEditPart.Name = "btnEditPart";
            this.btnEditPart.Size = new System.Drawing.Size(184, 42);
            this.btnEditPart.TabIndex = 11;
            this.btnEditPart.Text = "編輯零件";
            this.btnEditPart.UseVisualStyleBackColor = true;
            this.btnEditPart.Click += new System.EventHandler(this.btnEditPart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "關鍵字:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Location = new System.Drawing.Point(1074, 674);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(184, 42);
            this.btnStockOut.TabIndex = 9;
            this.btnStockOut.Text = "零件出庫";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.Location = new System.Drawing.Point(856, 674);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(184, 42);
            this.btnStockIn.TabIndex = 8;
            this.btnStockIn.Text = "零件入庫";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(500, 674);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(184, 42);
            this.btnDeletePart.TabIndex = 7;
            this.btnDeletePart.Text = "刪除零件";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(281, 674);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(184, 42);
            this.btnAddPart.TabIndex = 6;
            this.btnAddPart.Text = "新增零件";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect,
            this.PartNumber,
            this.PartName,
            this.StorageLocation,
            this.Quantity,
            this.LowerLimit,
            this.UpperLimit,
            this.Note});
            this.dgvParts.Location = new System.Drawing.Point(23, 87);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 51;
            this.dgvParts.RowTemplate.Height = 27;
            this.dgvParts.Size = new System.Drawing.Size(1266, 548);
            this.dgvParts.TabIndex = 5;
            this.dgvParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellContentClick);
            // 
            // lblSearchCount
            // 
            this.lblSearchCount.AutoSize = true;
            this.lblSearchCount.Location = new System.Drawing.Point(1224, 35);
            this.lblSearchCount.Name = "lblSearchCount";
            this.lblSearchCount.Size = new System.Drawing.Size(50, 20);
            this.lblSearchCount.TabIndex = 4;
            this.lblSearchCount.Text = "0/000";
            this.lblSearchCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1071, 30);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 30);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "下一筆";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(942, 30);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(114, 30);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "上一筆";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // cmbSearchField
            // 
            this.cmbSearchField.FormattingEnabled = true;
            this.cmbSearchField.Location = new System.Drawing.Point(771, 31);
            this.cmbSearchField.Name = "cmbSearchField";
            this.cmbSearchField.Size = new System.Drawing.Size(121, 28);
            this.cmbSearchField.TabIndex = 1;
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(525, 30);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(214, 31);
            this.txtSearchKeyword.TabIndex = 0;
            this.txtSearchKeyword.TextChanged += new System.EventHandler(this.txtSearchKeyword_TextChanged);
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.label3);
            this.tabHistory.Controls.Add(this.label2);
            this.tabHistory.Controls.Add(this.label1);
            this.tabHistory.Controls.Add(this.dgvHistory);
            this.tabHistory.Controls.Add(this.btnSearchHistory);
            this.tabHistory.Controls.Add(this.dtEnd);
            this.tabHistory.Controls.Add(this.dtStart);
            this.tabHistory.Controls.Add(this.txtKeywordHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 30);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(1313, 740);
            this.tabHistory.TabIndex = 2;
            this.tabHistory.Text = "    歷史紀錄     ";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(834, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "結束:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "起始:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "關鍵字收尋:";
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(28, 95);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 27;
            this.dgvHistory.Size = new System.Drawing.Size(1256, 613);
            this.dgvHistory.TabIndex = 4;
            // 
            // btnSearchHistory
            // 
            this.btnSearchHistory.Location = new System.Drawing.Point(1153, 36);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.Size = new System.Drawing.Size(107, 31);
            this.btnSearchHistory.TabIndex = 3;
            this.btnSearchHistory.Text = "查詢";
            this.btnSearchHistory.UseVisualStyleBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(893, 36);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 31);
            this.dtEnd.TabIndex = 2;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(607, 36);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 31);
            this.dtStart.TabIndex = 1;
            // 
            // txtKeywordHistory
            // 
            this.txtKeywordHistory.Location = new System.Drawing.Point(286, 36);
            this.txtKeywordHistory.Name = "txtKeywordHistory";
            this.txtKeywordHistory.Size = new System.Drawing.Size(245, 31);
            this.txtKeywordHistory.TabIndex = 0;
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "勾選框";
            this.chkSelect.MinimumWidth = 6;
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Width = 80;
            // 
            // PartNumber
            // 
            this.PartNumber.HeaderText = "零件編號";
            this.PartNumber.MinimumWidth = 6;
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.ReadOnly = true;
            this.PartNumber.Width = 125;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "零件名稱";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            this.PartName.Width = 125;
            // 
            // StorageLocation
            // 
            this.StorageLocation.HeaderText = "存放位置";
            this.StorageLocation.MinimumWidth = 6;
            this.StorageLocation.Name = "StorageLocation";
            this.StorageLocation.ReadOnly = true;
            this.StorageLocation.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "當前庫存";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 120;
            // 
            // LowerLimit
            // 
            this.LowerLimit.HeaderText = "下限";
            this.LowerLimit.MinimumWidth = 6;
            this.LowerLimit.Name = "LowerLimit";
            this.LowerLimit.ReadOnly = true;
            this.LowerLimit.Width = 80;
            // 
            // UpperLimit
            // 
            this.UpperLimit.HeaderText = "上限";
            this.UpperLimit.MinimumWidth = 6;
            this.UpperLimit.Name = "UpperLimit";
            this.UpperLimit.Width = 80;
            // 
            // Note
            // 
            this.Note.HeaderText = "備註";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 125;
            // 
            // tabControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 798);
            this.Controls.Add(this.tabControl1);
            this.Name = "tabControlMain";
            this.Text = "庫存管理系統";
            this.Load += new System.EventHandler(this.tabControlMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRecentTransactions;
        private System.Windows.Forms.ComboBox cmbSearchField;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblSearchCount;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnSearchHistory;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.TextBox txtKeywordHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditPart;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowerLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}

