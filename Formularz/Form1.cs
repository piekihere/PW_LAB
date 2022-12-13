using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//save
        {
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            try
            {
                Uczelnia uczelnia = new(textBox1.Text, comboBox3.Text, textBox3.Text, textBox4.Text, comboBox1.Text, comboBox2.Text);
            }
            catch (UczelniaException Exception)
            {
                label22.Text = Exception.Message;
                label22.ForeColor = Color.Red;
                label22.Visible = true;
                return;
            }
            catch (StudentException Exception)
            {
                label23.Text = Exception.Message;
                label23.ForeColor = Color.Red;
                label23.Visible = true;
                return;
            }
            catch (PracaException Exception)
            {
                label24.Text = Exception.Message;
                label24.ForeColor = Color.Red;
                label24.Visible = true;
                return;
            }


        }

        private void button2_Click(object sender, EventArgs e)//load
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Politechnika Poznañska";
            textBox1.Enabled = false;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}