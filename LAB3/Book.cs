using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Book
    {
        string title { get; set; }
        string author { get; set; }
        string id { get; set; }
        public Book(string title, string author, string id)
        {
            this.title = title;
            this.author = author;
            this.id = id;
        }
        public string[] getRow()
        {
            string[] row = { this.title, this.author, this.id };
            return row;
        }
    }
}
