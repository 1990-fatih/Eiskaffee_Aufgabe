using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiskaffee_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Eiskaffee!");
            // Fülle die Speisekarte mit Produkten
            Spelsekarte spelsekarte = new Spelsekarte() { beschreibung="SpelKarte1"};

            Produkt kaffelatte = new Produkt() { id=1,preis=2.5,mehrwertSteurSatz=0.5,produkttName="Kaffelatte"};
            Produkt Apfelkuhen = new Produkt() { id=2,preis=3.5,mehrwertSteurSatz=0.5,produkttName="Apfelkuhen"};
            Produkt Cheesecake = new Produkt() { id=3,preis=6,mehrwertSteurSatz=0.5,produkttName= "Cheesecake" };
            Produkt Schwarztee = new Produkt() { id = 4, preis = 2, mehrwertSteurSatz = 0.2, produkttName = "SchwarzTee" };

            spelsekarte.AddProdukt(kaffelatte);
            spelsekarte.AddProdukt(Apfelkuhen);
            spelsekarte.AddProdukt(Cheesecake);
            spelsekarte.AddProdukt(Schwarztee);


            foreach (var item in spelsekarte.Produkte)
            {
                Console.WriteLine(item.produkttName);
            }

            // Bestellung

            Bestellung b1 = new Bestellung();
            b1.BeschtellungsID = 1;
            b1.tisch = new Tisch_Gast() { tischnummer = 1 };
            b1.Kellner = new Kellner() { Name = "Phillip" };
            b1.AddProdukt(spelsekarte.Produkte[0], 2);
            b1.AddProdukt(spelsekarte.Produkte[3], 2);
        }
    }
}
