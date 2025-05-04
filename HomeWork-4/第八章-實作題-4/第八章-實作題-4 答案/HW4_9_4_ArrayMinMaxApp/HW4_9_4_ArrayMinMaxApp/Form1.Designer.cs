namespace HW4_9_4_ArrayMinMaxApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtNum4 = new TextBox();
            txtNum5 = new TextBox();
            txtNum6 = new TextBox();
            btnCalculate = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Microsoft JhengHei UI", 13.8F);
            txtNum1.Location = new Point(148, 129);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(80, 37);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Microsoft JhengHei UI", 13.8F);
            txtNum2.Location = new Point(234, 129);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(80, 37);
            txtNum2.TabIndex = 1;
            // 
            // txtNum3
            // 
            txtNum3.Font = new Font("Microsoft JhengHei UI", 13.8F);
            txtNum3.Location = new Point(320, 129);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(80, 37);
            txtNum3.TabIndex = 2;
            // 
            // txtNum4
            // 
            txtNum4.Font = new Font("Microsoft JhengHei UI", 13.8F);
            txtNum4.Location = new Point(406, 129);
            txtNum4.Name = "txtNum4";
            txtNum4.Size = new Size(80, 37);
            txtNum4.TabIndex = 3;
            // 
            // txtNum5
            // 
            txtNum5.Font = new Font("Microsoft JhengHei UI", 13.8F);
            txtNum5.Location = new Point(492, 129);
            txtNum5.Name = "txtNum5";
            txtNum5.Size = new Size(80, 37);
            txtNum5.TabIndex = 4;
            // 
            // txtNum6
            // 
            txtNum6.Font = new Font("Microsoft JhengHei UI", 13.8F);
            txtNum6.Location = new Point(578, 129);
            txtNum6.Name = "txtNum6";
            txtNum6.Size = new Size(80, 37);
            txtNum6.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnCalculate.Location = new Point(297, 331);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(220, 74);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "button1";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelResult.Location = new Point(149, 243);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(79, 29);
            labelResult.TabIndex = 7;
            labelResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtNum6);
            Controls.Add(txtNum5);
            Controls.Add(txtNum4);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtNum4;
        private TextBox txtNum5;
        private TextBox txtNum6;
        private Button btnCalculate;
        private Label labelResult;
    }
}
