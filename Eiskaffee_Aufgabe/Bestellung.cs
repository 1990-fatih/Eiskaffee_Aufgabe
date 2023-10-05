using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiskaffee_Aufgabe
{
    internal class Bestellung
    {
        public int BeschtellungsID { get; set; }

        public Tisch_Gast tisch { get; set; }

        public DateTime datum { get; set; }

        public List<Angebots_Position> AngebotsProduktListe { get; set; } = new List<Angebots_Position>();
        public Kellner Kellner { get; set; }
        internal void AddProdukt(Produkt produkt, int anzahl)
        {
            AngebotsProduktListe.Add(new Angebots_Position() { Produkt = produkt, Anzahl = anzahl });
        }

        public Rechnung UmwandelnInRechnung(Bestellung b)
        {
            Rechnung rg = new Rechnung();
            return rg;
        }
    }
}
