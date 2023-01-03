using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB11
{
    public partial class DetailsForm : Form
    {
        private Form1 other;
        private string airportName;
        public DetailsForm()
        {
            InitializeComponent();
        }
        public DetailsForm(string nazwa, Form1 other)
        {
            InitializeComponent();
            airportName = nazwa;
            this.other = other;
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            foreach(Airport lotnisko in other.AirportList)
            {
                StringBuilder details = new StringBuilder();
                if(airportName == lotnisko.nazwa)
                {
                    if (other.checkBox1.Checked)
                    {
                        details.AppendLine("Kod ICAO: " + lotnisko.icao);
                    }
                    if (other.checkBox2.Checked)
                    {
                        details.AppendLine("Kod IATA: " + lotnisko.iata);
                    }
                    if (other.checkBox3.Checked)
                    {
                        details.AppendLine("Liczba pasazerow: " + lotnisko.pasazerowie);
                    }
                    if (other.checkBox4.Checked)
                    {
                        details.AppendLine("Wojewodztwo: " + lotnisko.wojewodztwo);
                    }
                    if (other.checkBox5.Checked)
                    {
                        details.AppendLine("Miasto: " + lotnisko.miasto);
                    }
                    textBox1.Text = details.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
