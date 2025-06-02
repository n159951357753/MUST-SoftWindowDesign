namespace KStudyCenterAdmin
{
    partial class MainForm
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
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.btnBatchReserve = new System.Windows.Forms.Button();
            this.btnBatchDelete = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.btnPrevDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(136, 43);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(267, 40);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToAddRows = false;
            this.dataGridViewReservations.AllowUserToDeleteRows = false;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(28, 122);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 27;
            this.dataGridViewReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReservations.Size = new System.Drawing.Size(1072, 467);
            this.dataGridViewReservations.TabIndex = 1;
            this.dataGridViewReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservations_CellContentClick);
            // 
            // txtBatchName
            // 
            this.txtBatchName.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBatchName.Location = new System.Drawing.Point(223, 649);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(180, 40);
            this.txtBatchName.TabIndex = 2;
            // 
            // btnBatchReserve
            // 
            this.btnBatchReserve.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBatchReserve.Location = new System.Drawing.Point(479, 649);
            this.btnBatchReserve.Name = "btnBatchReserve";
            this.btnBatchReserve.Size = new System.Drawing.Size(114, 42);
            this.btnBatchReserve.TabIndex = 3;
            this.btnBatchReserve.Text = "批量預約";
            this.btnBatchReserve.UseVisualStyleBackColor = true;
            this.btnBatchReserve.Click += new System.EventHandler(this.btnBatchReserve_Click);
            // 
            // btnBatchDelete
            // 
            this.btnBatchDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBatchDelete.Location = new System.Drawing.Point(653, 649);
            this.btnBatchDelete.Name = "btnBatchDelete";
            this.btnBatchDelete.Size = new System.Drawing.Size(114, 42);
            this.btnBatchDelete.TabIndex = 4;
            this.btnBatchDelete.Text = "批量刪除";
            this.btnBatchDelete.UseVisualStyleBackColor = true;
            this.btnBatchDelete.Click += new System.EventHandler(this.btnBatchDelete_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearSelection.Location = new System.Drawing.Point(893, 41);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(174, 42);
            this.btnClearSelection.TabIndex = 5;
            this.btnClearSelection.Text = "清除全部勾選";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // btnPrevDay
            // 
            this.btnPrevDay.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevDay.Location = new System.Drawing.Point(472, 41);
            this.btnPrevDay.Name = "btnPrevDay";
            this.btnPrevDay.Size = new System.Drawing.Size(114, 42);
            this.btnPrevDay.TabIndex = 6;
            this.btnPrevDay.Text = "前一天";
            this.btnPrevDay.UseVisualStyleBackColor = true;
            this.btnPrevDay.Click += new System.EventHandler(this.btnPrevDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextDay.Location = new System.Drawing.Point(606, 41);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(114, 42);
            this.btnNextDay.TabIndex = 7;
            this.btnNextDay.Text = "後一天";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(76, 656);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "預約姓名:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 747);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.btnPrevDay);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btnBatchDelete);
            this.Controls.Add(this.btnBatchReserve);
            this.Controls.Add(this.txtBatchName);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.dateTimePickerDate);
            this.Name = "MainForm";
            this.Text = " 預約K書座位系統";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.Button btnBatchReserve;
        private System.Windows.Forms.Button btnBatchDelete;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnPrevDay;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.Label label1;
    }
}

