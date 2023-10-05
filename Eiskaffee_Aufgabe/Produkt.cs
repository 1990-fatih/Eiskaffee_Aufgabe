using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiskaffee_Aufgabe
{
    internal class Produkt
    {
        public int id { get; set; }

        public string produkttName { get; set; }

        public double preis { get; set; }

        public string beschreibung { get; set; }

        public double mehrwertSteurSatz { get; set; }
    }
}
