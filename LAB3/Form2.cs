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
            Book ksiazka = new Book(textBox1.Text, textBox2.Text, Guid.NewGuid().ToString() );
            other.dataGridView1.Rows.Add(ksiazka.getRow());
            textBox1.Clear();
            textBox2.Clear();
            
            
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
    }
}

