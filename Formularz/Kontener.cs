using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    public class Kontener
    {
        public Kontener() { }
        //uczelnia
        public string uczelnia;
        public string kierunek;
        public string zakres;
        public string profil;
        public string forma;
        public string poziom;
        public void Fill_uczelnia(string uczelnia, string kierunek, string zakres, string profil, string forma, string poziom)
        {
            this.uczelnia = uczelnia;
            this.kierunek = kierunek;
            this.zakres = zakres;
            this.profil = profil;
            this.forma = forma;
            this.poziom = poziom;
        }
        //studenci
        public List<string> imie = new List<string>();
        public List<string> indeks = new List<string>();
        public List<string> data = new List<string>();
        public void Fill_student(string imie, string indeks, string data)
        {
            this.imie.Add(imie);
            this.indeks.Add(indeks);
            this.data.Add(data);
        }


        //praca
        public string tytul;
        public string tytul_eng;
        public string dane_wejsciowe;
        public string zakres_pracy;
        public string termin;
        public string promotor;
        public string jednostka_organizacyjna;
        public void Fill_praca(string tytul, string tytul_eng, string dane_wejsciowe, string zakres_pracy, string termin, string promotor, string jednostka_organizacyjna)
        {
            this.tytul = tytul;
            this.tytul_eng = tytul_eng;
            this.dane_wejsciowe = dane_wejsciowe;
            this.zakres_pracy = zakres_pracy;
            this.termin = termin;
            this.promotor = promotor;
            this.jednostka_organizacyjna = jednostka_organizacyjna;
        }

        //data
        public string podpis;
        public void fill_podpis(string podpis)
        {
            this.podpis = podpis;
        }


    }
}
