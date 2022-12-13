using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    public class Praca
    {



        string tytul;
        string tytul_eng;
        string dane_wejsciowe;
        string zakres_pracy;
        string termin;
        string promotor;
        string jednostka_organizacyjna;
        public Praca(){}
        public Praca(string tytul, string tytul_eng, string dane_wejsciowe, string zakres_pracy, string termin, string promotor, string jednostka_organizacyjna)
        {

            if (tytul.Length > 0) { this.tytul = tytul; }
            else { throw new PracaException("Pole \"Tytuł pracy\" nie może być puste."); }

            if (tytul_eng.Length > 0) { this.tytul_eng = tytul_eng; }
            else { throw new PracaException("Pole \"Wersja angielska tytułu\" nie może być puste."); }

            if (dane_wejsciowe.Length > 0) { this.dane_wejsciowe = dane_wejsciowe; }
            else { throw new PracaException("Pole \"Dane wejsciowe\" nie może być puste."); }

            if (zakres_pracy.Length > 0) { this.zakres_pracy = zakres_pracy; }
            else { throw new PracaException("Pole \"Zakres pracy\" nie może być puste."); }

            DateTime dDate;
            if (DateTime.TryParse(termin, out dDate))
            {

                this.termin = String.Format("{0:d/MM/yyyy}", dDate);
            }
            else
            {
                throw new PracaException("Pole \"Termin oddania pracy\" musi mieć format dd/mm/yyyy.");
            }

            foreach (char c in promotor)
            {
                if (Char.IsLetter(c)) { continue; }
                else if (c == '-') { continue; }
                else if (Char.IsWhiteSpace(c)) { continue; }
                else if (c == '.') { continue; }
                else { throw new PracaException("Pole \"Promotor\" przyjmuje tylko litery, spacje oraz \"-\"."); }
            }
            if (promotor.Length == 0)
            {
                throw new PracaException("Pole \"Promotor\" nie może być puste.");
            }
            else
            {
                this.promotor = promotor;
            }
            if (jednostka_organizacyjna.Length > 0) { this.jednostka_organizacyjna = jednostka_organizacyjna; }
            else { throw new PracaException("Pole \"Jednostka organizacyjna promotora\" nie może być puste."); }
        }
    }
}
