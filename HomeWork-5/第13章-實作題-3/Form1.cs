namespace _13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLight_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblLight.BackColor = Color.Yellow;
                lblLight.Text = "���O";
            }
            else if (e.Button == MouseButtons.Right)
            {
                lblLight.BackColor = Color.LimeGreen;
                lblLight.Text = "��O";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLight.BackColor = Color.Red;
            lblLight.Text = "���O";

        }
    }
}
