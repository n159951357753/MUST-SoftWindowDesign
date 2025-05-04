namespace HW4_9_2_ArrayRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // 宣告 5 個元素的陣列
            int[] numbers = new int[5];
            Random rnd = new Random();

            // 產生 1~200 的亂數填入陣列
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 201); // 201 為上限(不含)
            }

            // 排序陣列
            Array.Sort(numbers);

            // 顯示結果在標籤
            labelResult.Text = "排序後的陣列: " + string.Join(", ", numbers);
        }
    }
}
