using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    public class Student
    {
        public string imie;
        public string indeks;
        public string data;
        public Student() { }
        public Student(string imie, string indeks,string data)
        {
            foreach(char c in imie)
            { 
                if (Char.IsLetter(c)) { continue; }
                else if(c == '-') { continue; }
                else if (Char.IsWhiteSpace(c)) { continue; }
                else { throw new StudentException("Pole \"Imie i nazwisko\" przyjmuje tylko litery, spacje oraz \"-\"."); }
            }      
            if (imie.Length == 0)
            {
                throw new StudentException("Pole \"Imie i nazwisko\" nie może być puste.");
            }
            else
            {
                this.imie = imie;
            }

            
            if (indeks.Length != 6)
            {
                throw new StudentException("\"Nr albumu\" musi mieć długość 6.");
            }
            else if (!indeks.All(c => Char.IsDigit(c)))
            {
                throw new StudentException("Pole \"Nr albumu\" przyjmuje tylko cyfry.");
            }
            else
            {
                this.indeks = indeks;
            }

            DateTime dDate;
            if (DateTime.TryParse(data, out dDate))
            {
                
                this.data = String.Format("{0:d/MM/yyyy}", dDate);
            }
            else
            {
                throw new StudentException("Pole \"Data\" musi mieć format dd/mm/yyyy.");
            }
        }
    }
}
