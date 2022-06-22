using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2
{
    class Punkt
    {
        private int x, y;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Punkt(Punkt p1)
        {
            this.x = p1.x;
            this.y = p1.y;
        }
        public Punkt()
        {
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void Wypisz()
        {
            Console.WriteLine($"Współrzedna x : {X}");
            Console.WriteLine($"Współrzedna y : {Y}");
        }

    }
}
