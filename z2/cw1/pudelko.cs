using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1
{
    class Pudelko
    {
        private int szerokosc;
        private int wysokosc;
        private int glebokosc;
        private string kolor;
        private static int ilosc = 0;

        public string Kolor
        {
            get { return kolor; }
            set { kolor = value; }
        }
        public void Wypisz()
        {
            Console.Write("Wysokośc pudełka to : ");
            Console.WriteLine(getWysokosc());
            Console.Write("Szerokośc pudełka to : ");
            Console.WriteLine(getSzerokosc());
            Console.Write("Głębokość pudełka to : ");
            Console.WriteLine(getGlebokosc());
            Console.Write("Kolor pudełka to : ");
            Console.WriteLine(getKolor());
        }

        public static int getIlosc()
        {
            return ilosc;
        }

        public void setSzerokosc(int _szerokosc)
        {
            szerokosc = _szerokosc;
        }

        public int  getSzerokosc()
        {
            return szerokosc;
        }
        public int  getWysokosc()
        {
            return wysokosc;
        }

        public int getGlebokosc()
        {
            return glebokosc;
        }
        public string getKolor()
        {
            return kolor;
        }

        public Pudelko(int _szerokosc, int wysokosc, int glebokosc, string kolor)
        {
            szerokosc = _szerokosc;
            this.wysokosc = wysokosc;
            this.glebokosc = glebokosc;
            this.kolor = kolor;
            ilosc += 1;
        }
         public Pudelko()
        {
            ilosc += 1;
        }

        public Pudelko(Pudelko p1)
        {
            szerokosc = p1.szerokosc;
            wysokosc = p1.wysokosc;
            glebokosc = p1.glebokosc;
            kolor = p1.kolor;
            ilosc += 1;
        }

        public int ObliczObjetosc()
        {
            return szerokosc * wysokosc * glebokosc;
        }
    }
}
