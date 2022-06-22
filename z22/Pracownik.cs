using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_IV_0._4
{
    internal class Pracownik
    {
        private string imie;
        private string nazwisko;
        private string dataUrodzenia;
        private double[] tablicaMiesiecznychDochodowPracownika;
        private static int iloscPracownikow;
        private static double sredniaPlacWszystkichPracownikow;
        private string dataZatrudnienia;
        public Pracownik(string imie, string nazwisko, string dataUrodzenia, string dataZatrudnienia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
            DataZatrudnienia = dataZatrudnienia;
            tablicaMiesiecznychDochodowPracownika = new double[20];
            IloscPracownikow++;

        }
        public string Imie { get { return imie; } set { imie = value; } }
        public string Nazwisko { get { return nazwisko; } set { nazwisko = value; } }
        public string DataUrodzenia { get { return dataUrodzenia; } set { dataUrodzenia = value; } }
        public static double SredniaPlacWszystkichPracownikow { get { return sredniaPlacWszystkichPracownikow;} set { sredniaPlacWszystkichPracownikow = value; } }
        public static int IloscPracownikow { get { return iloscPracownikow; } set { iloscPracownikow = value; } }
        public string DataZatrudnienia { get => dataZatrudnienia; set => dataZatrudnienia = value; }

        public virtual void drukuj()
        {
            Console.WriteLine($"imie: {Imie}");
            Console.WriteLine($"nazwisko: {Nazwisko}");
            Console.WriteLine($"data urodzenia: {DataUrodzenia}");
        }
        public static int ilePracownikow()
        {
            return IloscPracownikow;
        }
    }
}
