using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiskaffee_Aufgabe
{
    internal class Spelsekarte
    {
        public string beschreibung{ get; set; }
        public List<Produkt> Produkte { get; set; } = new List<Produkt>();
        public void AddProdukt(Produkt p)
        {
            Produkte.Add(p);
        }
    }
}
