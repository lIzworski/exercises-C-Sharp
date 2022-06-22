using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_IV_0._1
{
    internal class Osobowy : Samochod
    {
        private int iloscMiejsc;
        private int predkoscMaksymalna;

        public Osobowy(string marka, double pojemnoscSilnika, int przebieg, string wlasciciel, int iloscMiejs, int predkoscMaksymalna) : base(marka, pojemnoscSilnika, przebieg, wlasciciel)
        {
            IloscMiejsc = iloscMiejs;
            PredkoscMaksymalna = predkoscMaksymalna;
            IloscSamochodowOsobowych++;
        }

        public int IloscMiejsc { get { return iloscMiejsc; } set { iloscMiejsc = value; } }
        public int PredkoscMaksymalna { get { return predkoscMaksymalna; } set { predkoscMaksymalna = value; } }

        public void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine($",predkosc Maksymalna: {PredkoscMaksymalna}km/h, ilość miejsc: {IloscMiejsc}");
        }
    }
}
