using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiskaffee_Aufgabe
{
    internal class Rechnung
    {
        public int rechnungsId { get; set; }

        public Tisch_Gast tisch { get; set; }

        public DateTime datum { get; set; }

        public bool bezahlt { get; set; }
        public List<Produkt> RechnungsProduktListe { get; set; } = new List<Produkt>();
        public Kellner Kellner { get; set; }
    }


}
