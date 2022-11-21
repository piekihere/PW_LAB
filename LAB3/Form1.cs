using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB3
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form addWindow = new Form2(this);
            addWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory;

            StringBuilder data = new StringBuilder();

            var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
            data.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                data.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            //System.IO.File.WriteAllText(path, data.ToString());
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "CSV file (*.csv)|*.csv";
            
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(SaveFileDialog1.FileName);
                writer.Write(data);
                writer.Close();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "CSV file (*.csv)|*.csv";
            dataGridView1.Rows.Clear();
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (TextFieldParser parser = new TextFieldParser(OpenFileDialog1.FileName))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        //Process row
                        string[] fields = parser.ReadFields();
                        var fieldList = fields.ToList();
                        fieldList.Remove("Tytu³");
                        fieldList.Remove("Autor");
                        fieldList.Remove("ID");
                        fieldList.Remove("Wydawnictwo");
                        fieldList.Remove("Miasto");
                        fieldList.Remove("Rok");
                        fieldList.Remove("Status wypo¿yczenia");
                        for (int i = 0; i < fieldList.Count-6; i++)
                        {
                            dataGridView1.Rows.Add(fieldList[i], fieldList[i + 1], fieldList[i + 2], fieldList[i+3], fieldList[i+4],
                                fieldList[i + 5], fieldList[i+6]);
                            book ksiazka = new book();
                            ksiazka.tytul = fieldList[i];
                            ksiazka.autor = fieldList[i+1];
                            ksiazka.id = fieldList[i+2];
                            ksiazka.wydawnictwo = fieldList[i+3];
                            ksiazka.miasto = fieldList[i+4];
                            ksiazka.rok = fieldList[i+5];
                            ksiazka.status_wypozyczenia = fieldList[i+6];
                            bookList.Add(ksiazka);
                        }

                    }
                }
            }
         
        }

        private void button4_Click(object sender, EventArgs e)//save
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(List<book>));
            
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(SaveFileDialog1.FileName);
                serializer.Serialize(writer, bookList);
                writer.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)//load
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(List<book>));
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextReader reader = new StreamReader(OpenFileDialog1.FileName);
                bookList = (List<book>)serializer.Deserialize(reader);
            }
            foreach (book b in bookList)
            {
                dataGridView1.Rows.Add(b.tytul, b.autor, b.id, b.wydawnictwo, b.miasto, b.rok, b.status_wypozyczenia);
            }
        }
    }
}