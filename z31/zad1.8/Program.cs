using System;

namespace zad1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Program wyświetla liczby od 0 - 9 w trzech pętlach.");
            Console.WriteLine("Pętla for ");
            for(i = 0; i < 10; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("Pętka while ");
            i = 0;
            while (i < 10)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Pętla do while ");
            i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            }
            while (i < 10);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
