using System;

namespace zad2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wielkośc tabeli");
            int wielkoscTabeli = int.Parse(Console.ReadLine());
            double[] TabelaLiczb = new double[wielkoscTabeli];
            double srednia = 0, suma = 0;

            for(int i = 0; i < TabelaLiczb.Length; i++)
            {
                Console.WriteLine($"Podaj {i+1} liczbę ");
                double dodajLiczbeDoTabeli = double.Parse(Console.ReadLine());
                TabelaLiczb[i] = dodajLiczbeDoTabeli;
                suma += dodajLiczbeDoTabeli;
            }
            srednia = suma / wielkoscTabeli;
            Console.WriteLine();
            Console.WriteLine($"Suma wprowadzonych liczb wynosi {suma}");
            Console.WriteLine($"Średnia wprowadzonych licz wynosi {srednia}");
        }
    }
}
