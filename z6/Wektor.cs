using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._5
{
    //Treść tego zadania jest dla mnie niezrozumiała. 
    internal class Wektor
    {
        //a.
        private int wymiarWektora;
        private double[] dane;
        //b.
        public Wektor(int n, double [] dane)
        {
            this.wymiarWektora = n;
            this.dane = dane;
            dane = new double[n];
        }
        //c.
        public void Show()
        {
            for(int i = 0; i < dane.Length; i++)
            {
                Console.WriteLine(dane[i]);
            }
        }
        //d.
        public void sumuj()
        {
            double sum = 0;
            for(int j = 0; j < dane.Length; j++)
            {
                sum = sum + dane[j];
            }
            Console.WriteLine($"suma wszystkich współrzednych wynosi {sum:F3}");
        }

    }
}
