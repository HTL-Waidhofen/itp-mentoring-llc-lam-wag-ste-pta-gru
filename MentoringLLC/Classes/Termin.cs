using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoringLLC.Classes
{
    internal class Termin
    {
        string Titel { get; set; }
        string Fach { get; set; }
        int Teilnehmermoeglich { get; set; }
        int Teilnehmeranzahl { get; set; }
        DateTime Datum { get; set; }
        string Ort { get; set; }
        string Beschreibung { get; set; }

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
