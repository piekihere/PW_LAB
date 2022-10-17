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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dell");
            comboBox1.Items.Add("LG");
            comboBox1.Items.Add("Samsung");
            comboBox2.Items.Add("3440x1440px 34'");
            comboBox2.Items.Add("2560x1440px 27'");
            comboBox2.Items.Add("1920x1080px 24'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                partialPrice += 499;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                partialPrice += 699;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                partialPrice += 599;
            }
            if (comboBox2.SelectedIndex == 0)
            {
                partialPrice += 1500;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                partialPrice += 1100;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                partialPrice += 700;
            }
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
