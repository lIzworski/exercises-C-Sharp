using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._5_02
{
    //e.
    internal class Odcinek
    {
       private Punkt p1;
       private Punkt p2;
        //f.
        public Odcinek() { }
        public Odcinek(Punkt p1, Punkt p2) { this.p1 = p1; this.p2 = p2; }
        //g.
        public void Wypisz()
        {
            Console.WriteLine($"Współrzedne początka odcinka to x: {p1.X} y: {p1.Y}");
            Console.WriteLine($"Współrzedne końca odcinka to x: {p2.X} y: {p2.Y}");
        }
        //h.
        public double Dlugosc()
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
        //i.
        public void ZmienPoczątekOdcinka(int wspX, int wspY)
        {
            p1.X = wspX;
            p1.Y = wspY;
        }
        public void ZmienKoniecOdcinka(int wspX, int wspY)
        {
            p2.X = wspX;
            p2.Y = wspY;
        }
    }
}
