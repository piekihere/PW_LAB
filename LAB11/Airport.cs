using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11
{
    public class Airport
    {
        public string miasto {get;private set;}
        public string wojewodztwo {get; private set; }
        public string icao {get; private set; }
        public string iata { get;private set;}
        public string nazwa { get; private set; }
        public string pasazerowie { get; private set; }
        public string zmiana { get; private set; }


        public Airport(string miasto, string wojewodztwo, string icao, string iata, string nazwa, string pasazerowie, string zmiana)
        {
            this.miasto = miasto;
            this.wojewodztwo = wojewodztwo;
            this.icao = icao;
            this.iata = iata;
            this.nazwa = nazwa;
            this.pasazerowie = pasazerowie;
            this.zmiana = zmiana;
        }
    }
}
