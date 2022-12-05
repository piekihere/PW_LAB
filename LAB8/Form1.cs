namespace LAB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] {"Krokodyl", "Zajac", "Pies" });
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.AddRange(new string[] {"3x3","4x4","5x5" });
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string size = comboBox2.Text;
            string animal = comboBox1.Text;
            Form gameWindow = new Form2(this, size, animal);
            gameWindow.ShowDialog();
            
            
        }
    }
}