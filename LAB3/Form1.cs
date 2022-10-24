using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

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
                        for (int i = 0; i < fieldList.Count-2; i++)
                        {
                            dataGridView1.Rows.Add(fieldList[i], fieldList[i + 1], fieldList[i + 2]);
                        }
                    }
                }
            }
         
        }
    }
}