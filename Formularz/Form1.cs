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
            Student s1 = new Student(textBox5.Text, textBox6.Text, textBox7.Text);
            Student s2 = new Student(textBox8.Text, textBox9.Text, textBox10.Text);
            Student s3 = new Student(textBox11.Text, textBox12.Text, textBox13.Text);
            Student s4 = new Student(textBox22.Text, textBox21.Text, textBox2.Text);
            Student[] input = { s1, s2, s3, s4 };
            List<Student> StudentList = new List<Student>(input); 
        }

        private void button2_Click(object sender, EventArgs e)//load
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Politehnika Poznañska";
            
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