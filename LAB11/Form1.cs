using System.Data;
using System.Globalization;
using System.Windows.Forms;
using CsvHelper;

namespace LAB11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                    using (StreamReader openFile = File.OpenText(openFileDialog.FileName))
                    using (CsvReader csvFile = new CsvReader(openFile, CultureInfo.InvariantCulture))
                    {
                        using (var csvData = new CsvDataReader(csvFile))
                        {
                            DataTable data = new DataTable();
                            data.Load(csvData);
                            foreach(DataRow row in data.Rows)
                            {
                                listBox1.Items.Add(row[4]);

                                Airport lotnisko = new Airport(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(),
                                    row[4].ToString(), row[5].ToString(), row[6].ToString());
                                AirportList.Add(lotnisko);
                        }
                        }
                    }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm(listBox1.GetItemText(listBox1.SelectedItem).ToString(), this);
            detailsForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}