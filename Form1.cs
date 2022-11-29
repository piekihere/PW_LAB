using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //save
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(SaveFileDialog1.FileName);
                serializer.Serialize(writer, BookList);
                writer.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //load
            dataGridView1.Rows.Clear();
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextReader reader = new StreamReader(OpenFileDialog1.FileName);
                BookList = (List<Book>)serializer.Deserialize(reader);
            }
            foreach (Book b in BookList)
            {
                if (b.state.Equals(true))
                {
                    dataGridView1.Rows.Add(b.title, b.author, "Borrowed", b.id);
                }
                else
                {
                    dataGridView1.Rows.Add(b.title, b.author, "Not borrowed", b.id);
                }
            }
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddForm = new AddForm(this, "book");
            AddForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                foreach (Book book in BookList)
                {
                    if (book.id == dataGridView1.SelectedRows[0].Cells[3].Value.ToString())
                    {
                        BookList.Remove(book);
                        break;
                    }
                }
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
            dataGridView1.ClearSelection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //change state
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                foreach(Book b in BookList)
                {
                    if( b.id == dataGridView1.SelectedRows[0].Cells[3].Value.ToString())
                    {
                        if(b.state == true)
                        {
                            b.state = false;
                            dataGridView1.SelectedRows[0].Cells[2].Value = "Not borrowed";
                        }
                        else
                        {
                            b.state = true;
                            dataGridView1.SelectedRows[0].Cells[2].Value = "Borrowed";
                        }
                    }
                }
            }
            dataGridView1.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form AddForm = new AddForm(this, "user");
            AddForm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(SaveFileDialog1.FileName);
                serializer.Serialize(writer, UserList);
                writer.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextReader reader = new StreamReader(OpenFileDialog1.FileName);
                UserList = (List<User>)serializer.Deserialize(reader);
            }
            foreach(User user in UserList)
            {
                dataGridView2.Rows.Add(user.name,user.surname,user.id);
            }
            dataGridView2.ClearSelection();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0 && dataGridView2.SelectedRows.Count > 0)
            {
                foreach (User user in UserList)
                {
                    if (user.id == dataGridView2.SelectedRows[0].Cells[2].Value.ToString())
                    {
                        UserList.Remove(user);
                        break;
                    }
                }
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }
             
            dataGridView2.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}