using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LAB3
{
    public class Book
    {
        //[XmlAnyAttribute]
        public string tytul;
        public string autor;
        public string id;
        public string wydawnictwo;
        public string miasto;
        public string rok;
        public string status_wypozyczenia;

    }
}
