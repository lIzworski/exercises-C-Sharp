using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._5_02
{
    //a.
    internal class Punkt
    {
        private int x;
        private int y;
        //b.
        public Punkt() { }
        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }
        //c.
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        //d.
        public void Wypisz()
        {
            Console.WriteLine($"Współrzedna x: {X}");
            Console.WriteLine($"Współrzedna y: {Y}");
        }
    }
}
