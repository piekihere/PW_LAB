using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form2 : Form
    {
        private Form1 other;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 other)
        {
            this.other = other;
            InitializeComponent(); 
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            other.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, Guid.NewGuid().ToString(), textBox3.Text,
                textBox4.Text, textBox5.Text, textBox6.Text);
            Book ksiazka = new Book();
            ksiazka.tytul = textBox1.Text;
            ksiazka.autor = textBox2.Text;
            ksiazka.id = Guid.NewGuid().ToString();
            ksiazka.wydawnictwo = textBox3.Text;
            ksiazka.miasto = textBox4.Text;
            ksiazka.rok = textBox5.Text;
            ksiazka.status_wypozyczenia = textBox6.Text;
            other.BookList.Add(ksiazka);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

