using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    internal class Uczelnia
    {
        string uczelnia;
        string kierunek;
        string zakres;
        string profil;
        string forma;
        string poziom;
        public Uczelnia(string uczelnia, string kierunek, string zakres, string profil, string forma, string poziom)
        {
            this.uczelnia = uczelnia;
            this.kierunek = kierunek;
            if (!zakres.All(c => Char.IsLetter(c)))
            {
                throw new UczelniaException("Pole \"Studia w zakresie\" przyjmuje tylko litery.");
            }
            else if (zakres.Length == 0)
            {
                throw new UczelniaException("Pole \"Studia w zakresie\" nie może być puste.");
            }
            else
            {
                this.zakres = zakres;
            }

            if (!profil.All(c => Char.IsLetter(c)))
            {
                throw new UczelniaException("Pole \"Profil studiów\" przyjmuje tylko litery.");
            }
            else if (profil.Length == 0)
            {
                throw new UczelniaException("Pole \"Profil studiów\" nie może być puste.");
            }
            else
            {
                this.profil = profil;
            }
            this.forma = forma;
            this.poziom = poziom;
        }
    }
}
