using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2
{
    class Odcinek
    {
        Punkt p1;
        Punkt p2;

        public Odcinek(Punkt p1, Punkt p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void Wypis()
        {
            Console.WriteLine("odcinek:");
            Console.WriteLine("Początek: ");
            this.p1.Wypisz();
            Console.WriteLine("Koniec: ");
            this.p2.Wypisz();
        }

        public void ZmienPoczątek(Punkt newp1)
        {
            this.p1.X = newp1.X;
            this.p1.Y = newp1.Y;
        }

        public void ZmienKoniec(Punkt newp2)
        {
            this.p2.X = newp2.X;
            this.p2.Y = newp2.Y;
        }

        public double Dlugosc()
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X,2) + Math.Pow(p1.Y - p2.Y,2 ));
        }


    }
}
