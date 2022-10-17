using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB2
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
            comboBox1.Items.Add("Windows 11");
            comboBox1.Items.Add("Windows 10");
            comboBox1.Items.Add("Linux Ubuntu 20.04");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
 
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                partialPrice += 100;
            }
            if (radioButton2.Checked)
            {
                partialPrice += 190;
            }
            if (radioButton3.Checked)
            {
                partialPrice += 290;
            }
            if (checkBox1.Checked)
            {
                partialPrice += 199;
            }
            if (checkBox2.Checked)
            {
                partialPrice += 349;
            }
            if (checkBox3.Checked)
            {
                partialPrice += 699;
            }
            if (checkBox5.Checked)
            {
                partialPrice += 89;
            }
            if (checkBox4.Checked)
            {
                partialPrice += 119;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                partialPrice += 499;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                partialPrice += 399;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                partialPrice += 0;
            }
            other.komputer = true;
            other.label1.Text = partialPrice.ToString();
            if (other.komputer == true && other.monitor == true)
            {
                other.label1.ForeColor = System.Drawing.Color.Green;
            }
            this.Close();
        }
    }
}
