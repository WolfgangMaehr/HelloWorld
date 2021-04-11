using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolfgang_Übung_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Das ist die Übung 1. ");
            Console.WriteLine("Drücke ENTER für den Start der Berechnung.")
           
            Console.ReadLine();
            //addieren von Zahleen 0 - 10
            Console.Write("bitte erste Zahl eingeben: ");
            string ersteZahl = Console.ReadLine();
            Console.Write("bitte zweie Zahl eingeben: ");
            string zweiteZahl = Console.ReadLine();

            //Zahl umwandeln in string
            float ersteZahlalsZahl = Convert.ToSingle(ersteZahl);
            float zweiteZahlalsZahl = Convert.ToSingle(zweiteZahl);

            //berechnen
            float summe = ersteZahlalsZahl + zweiteZahlalsZahl;

            //Ergebnisanzeige
            Console.WriteLine("Ergebnis: {0}", summe);
            Console.ReadLine();

        }
    }
}
    
