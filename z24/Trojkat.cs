using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_IV_0._2
{
    internal class Trojkat : Figura
    {
        private double bok_A;
        private double bok_B;
        private double bok_C;

        public Trojkat(int a, int b, int c, string typFigury, string kolorObramowania, string kolorKrawedzi) : base(typFigury, kolorObramowania, kolorKrawedzi)
        {
            Bok_A = a;
            Bok_B = b;
            Bok_C = c;
        }
        public double Bok_A { get { return bok_A; } set { bok_A = value; } }
        public double Bok_B { get { return bok_B; } set { bok_B = value; } }
        public double Bok_C { get { return bok_C; } set { bok_C = value; } }

        public override void pole()
        {
            double p = (Bok_A + Bok_B + Bok_C) / 2; 
            double poleTrojkata = Math.Sqrt(p*(p-Bok_A)*(p-Bok_B)*(p-Bok_C));
            Console.WriteLine($"Pole trójkąta wynosi: {poleTrojkata:f4}cm^2");
        }
        public override void obwod()
        {
            double obwod = Bok_A + Bok_B + Bok_C;
            Console.WriteLine($"Obwód trójkąta wynosi: {obwod} cm");
        }

    }
}
