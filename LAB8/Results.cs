using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class Results : Form
    {
        private Form2 other;
        private bool result;
        public Results(Form2 other,bool result)
        {
            InitializeComponent();
            this.other = other;
            this.result = result;
        }

        private void Results_Load(object sender, EventArgs e)
        {
            if (result)
            {
                BackColor = Color.Green;
                label1.Text = "WYGRANA";
            }
            else
            {
                BackColor = Color.Red;
                label1.Text = "PRZEGRANA";
            }
        }
    }
}
