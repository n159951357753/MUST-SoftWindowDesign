namespace _13_3
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
            lblLight = new Label();
            SuspendLayout();
            // 
            // lblLight
            // 
            lblLight.AutoSize = true;
            lblLight.BackColor = Color.Red;
            lblLight.Font = new Font("細明體_HKSCS-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblLight.Location = new Point(142, 98);
            lblLight.MaximumSize = new Size(100, 100);
            lblLight.MinimumSize = new Size(100, 100);
            lblLight.Name = "lblLight";
            lblLight.Size = new Size(100, 100);
            lblLight.TabIndex = 0;
            lblLight.Text = "紅燈";
            lblLight.TextAlign = ContentAlignment.MiddleCenter;
            lblLight.MouseClick += lblLight_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLight);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLight;
    }
}
