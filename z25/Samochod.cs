using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_IV_0._1
{
    internal class Samochod
    {
        private string marka;
        private double pojemnoscSilnika;
        private int przebieg;
        private string wlasciciel;
        private static int iloscSamochodow = 0;
        private static int iloscSamochodowOsobowych = 0;
        private static int iloscSamochodowCiezarowych = 0;
        public Samochod(string marka, double pojemnoscSilnika, int przebieg, string wlasciciel)
        {
            Marka = marka;
            PojemnoscSilnika = pojemnoscSilnika;
            Przebieg = przebieg;
            Wlasciciel = wlasciciel;
            iloscSamochodow++;
        }

        public static int IloscSamochodow { get { return iloscSamochodow; } set { iloscSamochodow = value; } }
        public static int IloscSamochodowOsobowych { get { return iloscSamochodowOsobowych; } set { iloscSamochodowOsobowych = value; } }
        public static int IloscSamochodowCiezarowych { get { return iloscSamochodowCiezarowych; } set { iloscSamochodowCiezarowych = value; } }
        public string Marka { get { return marka; } set { marka = value; } }
        public double PojemnoscSilnika { get { return pojemnoscSilnika; } set { pojemnoscSilnika = value; } }
        private int Przebieg { get { return przebieg; } set { przebieg = value;} }
        public string Wlasciciel { get { return wlasciciel; } set { wlasciciel = value; } }



        public void Wypisz()
        {
            Console.Write($"Marka:{Marka}, pojemnosc silnika: {PojemnoscSilnika}, przebieg: {Przebieg}km, własciciel: {Wlasciciel.ToUpper()}");
        }
        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine($"Ilość samochdów: { IloscSamochodow} w tym, osobowe: {IloscSamochodowOsobowych}, cieżarowe: {IloscSamochodowCiezarowych}");
        }
    }
}
