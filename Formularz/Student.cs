using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    public class Student
    {
        string imie;
        string nazwisko;
        string indeks;

        public Student(string imie, string nazwisko, string indeks)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.indeks = indeks;
        }
    }
}
