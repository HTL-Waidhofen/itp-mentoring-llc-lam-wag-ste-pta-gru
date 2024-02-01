using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoringLLC.Classes
{
    public class Termin
    {
        public string Titel { get; set; }
        public int id { get; set; }
        public string Fach { get; set; }
        public int Teilnehmermoeglich { get; set; }
        public int Teilnehmeranzahl { get; set; }
        public DateTime Datum { get; set; }
        public string Ort { get; set; }
        public string Beschreibung { get; set; }

        public Termin() { }

        public Termin(string titel, string fach, int teilnehmeranzahl, DateTime datum,  string ort, string beschreibung="") 
        { 
            Titel = titel;
            Fach = fach;
            Teilnehmermoeglich= teilnehmeranzahl;
            Datum = datum;
            Ort = ort;
            Beschreibung = beschreibung;
        }

    }
}
