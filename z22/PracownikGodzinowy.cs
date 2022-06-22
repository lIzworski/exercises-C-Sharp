using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_IV_0._4
{
    internal class PracownikGodzinowy : Pracownik 
    {
        private double stawkaGodzinowa;
        private int liczbaGodzin;
        
        public PracownikGodzinowy(string imie, string nazwisko, string dataUrodzenia, string dataZatrudnienia, double stawkaGodzinowa, int liczbGodzin) : base(imie, nazwisko, dataUrodzenia,dataZatrudnienia)
        {
            StawkaGodzinowa = stawkaGodzinowa;
            LiczbaGodzin = liczbGodzin;
        }
        public double StawkaGodzinowa { get { return stawkaGodzinowa; } set { stawkaGodzinowa = value; } }
        //Liczba Godzin w miesiącu.
        public int LiczbaGodzin { get { return liczbaGodzin; } set { liczbaGodzin = value; } }

        public double zarobekRoczny()
        {
            double zarobekRoczny = StawkaGodzinowa * LiczbaGodzin * 12;
            return zarobekRoczny;
        }
        public override void drukuj()
        {
            base.drukuj();
            Console.WriteLine($"stawka godzinowa: {StawkaGodzinowa}");
            Console.WriteLine($"zarobek roczny: {zarobekRoczny()}\n");
        }
    }
}
