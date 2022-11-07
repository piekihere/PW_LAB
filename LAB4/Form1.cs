namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();  
            /*open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";*/

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            //bmp.GetPixel(i,j).R == 0 && bmp.GetPixel(i, j).G==0 && bmp.GetPixel(i, j).B ==0
            //(bmp.GetPixel(i,j).GetBrightness() > 0.1)
            for (int i = 0; i < bmp.Width; i++)
            {
                for(int j = 0; j < bmp.Height; j++)
                {
                    if (bmp.GetPixel(i, j).GetBrightness() > 0.1)
                    {
                        bmp.SetPixel(i, j, Color.White);
                    }
                }
            }
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    if (bmp.GetPixel(i,j).GetHue()>=130 || bmp.GetPixel(i,j).GetHue()<=80)
                    {
                        bmp.SetPixel(i, j, Color.White);
                    }
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}