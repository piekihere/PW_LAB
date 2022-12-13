using System.Windows.Forms;
using System.Xml.Serialization;
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
            label25.Visible = false;
            StudentList.Clear();
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

            try
            {
                Student student1 = new(textBox5.Text, textBox6.Text, textBox7.Text);
                Student student2 = new(textBox8.Text, textBox9.Text, textBox10.Text);
                Student student3 = new(textBox11.Text, textBox12.Text, textBox13.Text);
                Student student4 = new(textBox22.Text, textBox21.Text, textBox2.Text);
                Student[] lista = {student1,student2,student3,student4 };
                StudentList.AddRange(lista);
            }
            catch (StudentException Exception)
            {
                label23.Text = Exception.Message;
                label23.ForeColor = Color.Red;
                label23.Visible = true;
                return;
            }

            try
            {
                Praca praca = new(textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text, textBox18.Text, textBox19.Text, textBox20.Text);
            }
            catch (PracaException Exception)
            {
                label24.Text = Exception.Message;
                label24.ForeColor = Color.Red;
                label24.Visible = true;
                return;
            }
            DateTime dDate;
            string data;
            try
            {
                if (DateTime.TryParse(textBox23.Text, out dDate))
                {

                    data = String.Format("{0:d/MM/yyyy}", dDate);
                }
                else
                {
                    throw new DataException("Pole \"Data\" musi mieæ format dd/mm/yyyy.");
                }
            }
            catch ( DataException Exception)
            {
                label25.Text = Exception.Message;
                label25.ForeColor = Color.Red;
                label25.Visible = true;
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