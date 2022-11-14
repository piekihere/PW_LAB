using System.Windows.Forms;

namespace LAB5
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
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(open.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            dictOfSeqs.Clear();
            for(int i = 0; i < textBox1.Text.ToString().Length - 3; i++)
            {
                if(dictOfSeqs.ContainsKey(textBox1.Text.ToString().Substring(i, 4)))
                {
                    dictOfSeqs[textBox1.Text.ToString().Substring(i, 4)] += 1;
                }
                else
                {
                    dictOfSeqs[textBox1.Text.ToString().Substring(i, 4)] = 1;
                }
            }
            foreach (KeyValuePair<string, int> kvp in dictOfSeqs)
            {
                String wpis = kvp.Key +" : "+ kvp.Value.ToString();
                listView1.Items.Add(wpis);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}