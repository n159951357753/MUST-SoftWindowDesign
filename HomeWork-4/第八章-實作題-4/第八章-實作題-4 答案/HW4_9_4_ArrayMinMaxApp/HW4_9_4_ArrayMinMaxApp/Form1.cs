namespace HW4_9_4_ArrayMinMaxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ��̤p��
        private int arrMin(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        // ��̤j��
        private int arrMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ū���ϥΪ̿�J���Ʀr
                int[] numbers = new int[6]
                {
                    int.Parse(txtNum1.Text),
                    int.Parse(txtNum2.Text),
                    int.Parse(txtNum3.Text),
                    int.Parse(txtNum4.Text),
                    int.Parse(txtNum5.Text),
                    int.Parse(txtNum6.Text)
                };

                // �p��̤p�ȩM�̤j��
                int min = arrMin(numbers);
                int max = arrMax(numbers);

                // ��ܵ��G
                labelResult.Text = $"�̤p��: {min}, �̤j��: {max}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("�нT�{�Ҧ���J���O���Ī���ơI\n" + ex.Message);
            }
        }
    }

}


