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

        // т程
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

        // т程
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
                // 弄ㄏノ块计
                int[] numbers = new int[6]
                {
                    int.Parse(txtNum1.Text),
                    int.Parse(txtNum2.Text),
                    int.Parse(txtNum3.Text),
                    int.Parse(txtNum4.Text),
                    int.Parse(txtNum5.Text),
                    int.Parse(txtNum6.Text)
                };

                // 璸衡程㎝程
                int min = arrMin(numbers);
                int max = arrMax(numbers);

                // 陪ボ挡狦
                labelResult.Text = $"程: {min}, 程: {max}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("叫絋粄┮Τ块常琌Τ俱计\n" + ex.Message);
            }
        }
    }

}


