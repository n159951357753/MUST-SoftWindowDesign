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
            // �ŧi 5 �Ӥ������}�C
            int[] numbers = new int[5];
            Random rnd = new Random();

            // ���� 1~200 ���üƶ�J�}�C
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 201); // 201 ���W��(���t)
            }

            // �Ƨǰ}�C
            Array.Sort(numbers);

            // ��ܵ��G�b����
            labelResult.Text = "�Ƨǫ᪺�}�C: " + string.Join(", ", numbers);
        }
    }
}
