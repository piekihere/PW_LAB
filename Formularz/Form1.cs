using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//save
        {
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            Kontener kontener = new Kontener();
            
            try
            {
                Uczelnia uczelnia = new(textBox1.Text, comboBox3.Text, textBox3.Text, textBox4.Text, comboBox1.Text, comboBox2.Text);
                kontener.Fill_uczelnia(textBox1.Text, comboBox3.Text, textBox3.Text, textBox4.Text, comboBox1.Text, comboBox2.Text);
            }
            catch (UczelniaException Exception)
            {
                label22.Text = Exception.Message;
                label22.ForeColor = Color.Red;
                label22.Visible = true;
                return;
            }

            try
            {
                Student student1 = new(textBox5.Text, textBox6.Text, textBox7.Text);
                Student student2 = new(textBox8.Text, textBox9.Text, textBox10.Text);
                Student student3 = new(textBox11.Text, textBox12.Text, textBox13.Text);
                Student student4 = new(textBox22.Text, textBox21.Text, textBox2.Text);
                Student[] lista = {student1,student2,student3,student4 };
                
                foreach(Student student in lista)
                {
                    kontener.Fill_student(student.imie, student.indeks, student.data);
                }
            }
            catch (StudentException Exception)
            {
                label23.Text = Exception.Message;
                label23.ForeColor = Color.Red;
                label23.Visible = true;
                return;
            }
            try
            {
                Praca praca = new(textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text, textBox18.Text, textBox19.Text, textBox20.Text);
                kontener.Fill_praca(textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text, textBox18.Text, textBox19.Text, textBox20.Text);
            }
            catch (PracaException Exception)
            {
                label24.Text = Exception.Message;
                label24.ForeColor = Color.Red;
                label24.Visible = true;
                return;
            }
            DateTime dDate;
            string podpis;
            try
            {
                if (DateTime.TryParse(textBox23.Text, out dDate))
                {

                    podpis = String.Format("{0:d/MM/yyyy}", dDate);
                    kontener.fill_podpis(podpis);
                }
                else
                {
                    throw new DataException("Pole \"Data\" musi mieæ format dd/mm/yyyy.");
                }
            }
            catch ( DataException Exception)
            {
                label25.Text = Exception.Message;
                label25.ForeColor = Color.Red;
                label25.Visible = true;
                return;
            }


            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(Kontener));

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(SaveFileDialog1.FileName);
                serializer.Serialize(writer, kontener);
                writer.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)//load
        {
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(Kontener));
            Kontener kontener = new Kontener();
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextReader reader = new StreamReader(OpenFileDialog1.FileName);
                kontener = (Kontener)serializer.Deserialize(reader);


                //uczelnia
                textBox1.Text = kontener.uczelnia;
                comboBox3.SelectedText = kontener.kierunek;
                textBox3.Text = kontener.zakres;
                textBox4.Text = kontener.profil;
                comboBox1.SelectedText = kontener.forma;
                comboBox2.SelectedText = kontener.poziom;

                //student
                textBox5.Text = kontener.imie[0]; textBox6.Text = kontener.indeks[0]; textBox7.Text = kontener.data[0];
                textBox8.Text = kontener.imie[1]; textBox9.Text = kontener.indeks[1]; textBox10.Text = kontener.data[1];
                textBox11.Text = kontener.imie[2]; textBox12.Text = kontener.indeks[2]; textBox13.Text = kontener.data[2];
                textBox22.Text = kontener.imie[3]; textBox21.Text = kontener.indeks[3]; textBox2.Text = kontener.data[3];

                //praca dyplomowa
                textBox14.Text = kontener.tytul;
                textBox15.Text = kontener.tytul_eng;
                textBox16.Text = kontener.dane_wejsciowe;
                textBox17.Text = kontener.zakres_pracy;
                textBox18.Text = kontener.termin;
                textBox19.Text = kontener.promotor;
                textBox20.Text = kontener.jednostka_organizacyjna;
                textBox23.Text = kontener.podpis;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Politechnika Poznañska";
            textBox1.Enabled = false;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

    }
}