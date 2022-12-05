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
    public partial class Form2 : Form
    {
        private Form1 other;
        private string animal;
        private int size;
        private int row;
        private int col;
        public Form2(Form1 other, string size, string animal)
        {
            InitializeComponent();
            this.other = other;
            this.size = Int32.Parse(size.Substring(0,1));
            this.animal = animal;


        }
        private void initializeButtons(int size)
        {


            for (int i = 0;i < size; i++)
            {
                for(int j = 0;j < size; j++)
                {
                    Button button1 = new Button();
                    button1.Location = new System.Drawing.Point(i * 75, j * 75);
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
            initializeButtons(size);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }
        private void createButton_MouseEnter(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            string name = currentButton.Name;
            if (name == "WYGRANA")
            {
                this.Close();
            }
}
    }
}
