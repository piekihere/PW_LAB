namespace LAB2
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form komputer = new Form2(this);
            komputer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form monitor = new Form3(this);
            monitor.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}