using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace template
{
    public partial class AddForm : Form
    {
        private Form1 other;
        private string AddType;
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(Form1 other, string AddType)
        {
            InitializeComponent();
            this.other = other;
            this.AddType = AddType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(AddType == "book") {

                Book book = new Book();
                book.author = textBox1.Text;
                book.title = textBox2.Text;
                book.id = Guid.NewGuid().ToString();
                book.state = false;
                other.BookList.Add(book);
                other.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, "Not borrowed", book.id);
                other.dataGridView1.ClearSelection();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                User user = new User();
                user.name = textBox1.Text;
                user.surname = textBox2.Text;
                user.id = Guid.NewGuid().ToString();
                other.UserList.Add(user);
                other.dataGridView2.Rows.Add(textBox1.Text, textBox2.Text, user.id);
                other.dataGridView1.ClearSelection();
                textBox1.Clear();
                textBox2.Clear();

            }

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if(AddType == "book")
            {
                label1.Text = "Title";
                label2.Text = "Author";
                button1.Text = "Add book";
            }
            else
            {
                label1.Text = "Name";
                label2.Text = "Surname";
                button1.Text = "Add user";
            }
        }
    }
}
