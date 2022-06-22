using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_IV_0._1
{
    internal class Ciezarowy : Samochod
    {
        private int ladownosc;
        private int dopuszczalnaMasaPrzyczepy;

        public int Ladownosc { get { return ladownosc; } set { ladownosc = value; } }
        public int DopuszczalnaMasaPrzyczepy { get { return dopuszczalnaMasaPrzyczepy; } set { dopuszczalnaMasaPrzyczepy = value; } }

        public Ciezarowy(string marka, double pojemnoscSilnika, int przebieg,string wlasciciel , int ladownosc, int dopuszczalnaMasaPrzyczepy)
            : base(marka, pojemnoscSilnika, przebieg, wlasciciel)
        {
            Ladownosc = ladownosc;
            DopuszczalnaMasaPrzyczepy= dopuszczalnaMasaPrzyczepy;
            IloscSamochodowCiezarowych++;
        }
        public void  Wypisz()
        {
            base.Wypisz();
            Console.WriteLine($", ładowność: {Ladownosc}kg, dopuszczalna masa przyczepy: {DopuszczalnaMasaPrzyczepy}kg");
        }

    }
}
