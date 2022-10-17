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
    public partial class Form3 : Form
    {
        private Form1 other;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form1 other)
        {
            InitializeComponent();
            this.other = other;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dell");
            comboBox1.Items.Add("LG");
            comboBox1.Items.Add("Samsung");
            comboBox2.Items.Add("3440x1440px 34'");
            comboBox2.Items.Add("2560x1440px 27'");
            comboBox2.Items.Add("1920x1080px 24'");
            comboBox1Map[0] = 300;
            comboBox1Map[1] = 600;
            comboBox1Map[2] = 500;
            comboBox2Map[0] = 1549;
            comboBox2Map[1] = 1099;
            comboBox2Map[2] = 789;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formerComboBox1 == 3)
            {
                partialPrice += comboBox1Map[comboBox1.SelectedIndex];
                partialPriceLabel.Text = partialPrice.ToString();
            }
            else
            {
                partialPrice += comboBox1Map[comboBox1.SelectedIndex];
                partialPrice -= comboBox1Map[formerComboBox1];
                partialPriceLabel.Text = partialPrice.ToString();
            }
            formerComboBox1 = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formerComboBox2 == 3)
            {
                partialPrice += comboBox2Map[comboBox2.SelectedIndex];
                partialPriceLabel.Text = partialPrice.ToString();
            }
            else
            {
                partialPrice += comboBox2Map[comboBox2.SelectedIndex];
                partialPrice -= comboBox2Map[formerComboBox2];
                partialPriceLabel.Text = partialPrice.ToString();
            }
            formerComboBox2 = comboBox2.SelectedIndex;
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
            other.monitor = true;
            other.label1.Text = (Int32.Parse(other.label1.Text) + partialPrice ).ToString();
            if(other.komputer == true && other.monitor == true)
            {
                other.label1.ForeColor = System.Drawing.Color.Green;
            }
            this.Close();
        }
    }
}
