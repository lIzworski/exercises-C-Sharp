using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_II._7
{
    internal class Sprzedaz
    {
        private string nazwa;
        private int ilosc;
        private double cena;

        public string Nazwa { get { return nazwa; } set { nazwa = value; } }
        public int Ilosc { get { return ilosc; } set { ilosc = value; } }
        public double Cena { get { return cena; } set { cena = value; } }

        public Sprzedaz(string p, int a, double sP)
        {
            Nazwa = p;
            Ilosc = a;
            cena = sP;
        }
        public void sprzedany()
        {
            Console.WriteLine($"Cena za sztuke: {Cena:C} sztuk: {Ilosc}, nazwa artykułu: {Nazwa.ToUpper()}");
        }

        public void kopiujObiekt(Sprzedaz p1)
        {
            this.Nazwa = p1.Nazwa;
            this.Ilosc = p1.Ilosc;
            this.Cena = p1.Cena;
        }
    }
}
