using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            label1.Text = stopwatch.Elapsed.ToString("mm\\:ss\\.ff");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
