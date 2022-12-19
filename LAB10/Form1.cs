using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace LAB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                if (checkBox1.Checked)
                {
                    Random rand = new Random();
                    string random = MusicVault.ElementAt(rand.Next(0, MusicVault.Count)).Value;
                    MusicPlayer.SoundLocation = random;
                    MusicPlayer.Play();

                }
                else
                {
                    foreach (KeyValuePair<string, string> track in MusicVault)
                    {
                        if (track.Key == dataGridView1.SelectedRows[0].Cells[1].Value.ToString())
                        {
                            MusicPlayer.SoundLocation = track.Value;
                            MusicPlayer.Play();
                            break;
                        }
                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Filter = "WAV files (*.wav)|*.wav";
            ofd.DefaultExt = ".wav";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] names = ofd.SafeFileNames;
                string[] paths = ofd.FileNames;
                for( int i=0 ; i < names.Length; i++)
                {
                    string ID = Guid.NewGuid().ToString();
                    dataGridView1.Rows.Add(names[i], ID);
                    MusicVault.Add(ID, paths[i]);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
/*            double currentPos = MusicPlayer.CurrentPosition;
            MusicPlayer.Play();
            MusicPlayer.Seek(currentPos);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusicPlayer.Stop();
        }
    }
}