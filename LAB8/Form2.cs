using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class Form2 : Form
    {
        private Form1 other;
        private string animal;
        private int size;
        private int row;
        private int col;
        private bool flag = false;
        private Stopwatch timer = new Stopwatch();
        public Form2(Form1 other, string size, string animal)
        {
            InitializeComponent();
            this.other = other;
            this.size = Int32.Parse(size.Substring(0,1));
            this.animal = animal;


        }
        private void initializeButtons(int size,int row,int col)
        {


            for (int i = 0;i < size; i++)
            {
                for(int j = 0;j < size; j++)
                {
                    Button button1 = new Button();
                    button1.Location = new System.Drawing.Point(i * 75, 30+j * 75);
                    button1.Size = new System.Drawing.Size(75, 75);
                    button1.Text = "";
                    button1.Name = i + "," + j;
                    button1.Click += createButton_MouseEnter;
                    
                    Controls.Add(button1);
                    if (i == row && j == col)
                    {
                        button1.Name ="WYGRANA";
                    }

                    
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int row = rnd.Next(0, size);
            int col = rnd.Next(0, size);
            //this.ClientSize = new System.Drawing.Size(size*100, size*100);
            initializeButtons(size,row, col);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }
        private void createButton_MouseEnter(object sender, EventArgs e)
        {
            if(!flag)
            {
                timer.Start();
                flag = true;
            }
            Button currentButton = sender as Button; 
            if (currentButton.Name == "WYGRANA")
            {
                timer.Stop();
                currentButton.Text = animal;
                if(animal == "Krokodyl")
                {
                    DisableButtons();
                    Random rnd = new Random();
                    int prob = rnd.Next(100);
                    if(prob < 50)
                    {
                        Results result = new Results(this, false);
                        result.Show();
                    }
                    else
                    {
                        Results result = new Results(this, true);
                        result.Show();
                    }
                }
                else
                {
                    timer.Stop();
                    DisableButtons();
                    Results result = new Results(this, true);
                    result.Show();
                }
            }
            else
            {
                currentButton.Text = "X";
            }
}
        void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = false;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = timer.Elapsed;
            label1.Text = String.Format("Time passed: {0}.{1}s",ts.Seconds,ts.Milliseconds / 10);
            if (ts.Seconds == 3)
            {
                timer1.Stop();
                timer.Stop();
                DisableButtons();
                Results result = new Results(this, false);
                result.Show();
            }
        }
    }
}
