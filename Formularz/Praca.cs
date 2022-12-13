using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    internal class Praca
    {



        string tytul;
        string tytul_eng;
        string dane_wejsciowe;
        string zakres_pracy;
        string termin;
        string promotor;
        string jednostka_organizacyjna;
        public Praca(string tytul, string tytul_eng, string dane_wejsciowe, string zakres_pracy, string termin, string promotor, string jednostka_organizacyjna)
        {
   
            this.tytul = tytul;
            this.tytul_eng = tytul_eng;
            this.dane_wejsciowe = dane_wejsciowe;
            this.zakres_pracy = zakres_pracy;
            this.termin = termin;
            this.promotor = promotor;
            this.jednostka_organizacyjna = jednostka_organizacyjna;
        }
    }
}
