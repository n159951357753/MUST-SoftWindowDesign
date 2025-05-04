namespace HW4_9_2_ArrayRandom
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
            labelResult = new Label();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelResult.Location = new Point(259, 128);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(254, 29);
            labelResult.TabIndex = 0;
            labelResult.Text = "結果顯示: 按下按鈕開始";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            labelResult.Click += label1_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnGenerate.Location = new Point(261, 277);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(252, 86);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "產生亂數並排序";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerate);
            Controls.Add(labelResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResult;
        private Button btnGenerate;
    }
}
