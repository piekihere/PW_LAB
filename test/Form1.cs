namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Stoper = new Form2();
            Stoper.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}