using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_IV_0._2
{
    internal class Prostokat : Figura
    {
        private double bok_A;
        private double bok_B;

        public double Bok_A { get { return bok_A; } set { bok_A = value; } }
        public double Bok_B { get { return bok_B; } set { bok_B = value; } }

        public Prostokat(double a, double b, string typFigury, string kolorObramowania, string kolorKrawedzi): base(typFigury, kolorObramowania, kolorKrawedzi)
        {
            bok_A = a;
            bok_B = b;
        }
        public override void pole()
        {
            double poleProstokata = Bok_A * bok_B;
            Console.WriteLine($"Pole prostkąta wynosi:{poleProstokata}cm^2");
        }
        public override void obwod()
        {
            double obwodProstokata = (2 * Bok_A) + (2 * Bok_B);
            Console.WriteLine($"Obwód prostokąta wynosi: {obwodProstokata}cm");
        }
    }
}
