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
            comboBoxMap[0] = 499;
            comboBoxMap[1] = 399;
            comboBoxMap[2] = 0;
            this.comboBox1.SelectedIndex = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formerComboBox == 3)
            {
                partialPrice += comboBoxMap[comboBox1.SelectedIndex];
                partialPriceLabel.Text = partialPrice.ToString();
            }
            else
            {
                    partialPrice += comboBoxMap[comboBox1.SelectedIndex];
                    partialPrice -= comboBoxMap[formerComboBox];
                    partialPriceLabel.Text = partialPrice.ToString();
            }
            formerComboBox = comboBox1.SelectedIndex;
        }

       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                partialPrice += 100;
            }else if (!radioButton1.Checked)
            {
                partialPrice -= 100;
            }
             partialPriceLabel.Text = partialPrice.ToString();

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                partialPrice += 190;
            }
            else if (!radioButton2.Checked)
            {
                partialPrice -= 190;
            }
            partialPriceLabel.Text = partialPrice.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                partialPrice += 290;
            }
            else if (!radioButton3.Checked)
            {
                partialPrice -= 290;
            }
            partialPriceLabel.Text = partialPrice.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                partialPrice += 199;
            }
            else if (!checkBox1.Checked)
            {
                partialPrice -= 199;
            }
            partialPriceLabel.Text = partialPrice.ToString();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                partialPrice += 349;
            }
            else if (!checkBox2.Checked)
            {
                partialPrice -= 349;
            }
            partialPriceLabel.Text = partialPrice.ToString();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                partialPrice += 699;
            }
            else if (!checkBox3.Checked)
            {
                partialPrice -= 699;
            }
            partialPriceLabel.Text = partialPrice.ToString();

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                partialPrice += 119;
            }
            else if (!checkBox4.Checked)
            {
                partialPrice -= 119;
            }
            partialPriceLabel.Text = partialPrice.ToString();

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                partialPrice += 89;
            }
            else if (!checkBox5.Checked)
            {
                partialPrice -= 89;
            }
            partialPriceLabel.Text = partialPrice.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            
            other.komputer = true;
            other.label1.Text = (Int32.Parse(other.label1.Text) + partialPrice).ToString();
            if (other.komputer == true && other.monitor == true)
            {
                other.label1.ForeColor = System.Drawing.Color.Green;
            }
            this.Close();
        }
    }
}
