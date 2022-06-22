using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzający czy podana liczba jest parzysta");
            Console.WriteLine();
            Console.WriteLine("Podaj liczbe");
            int liczba = int.Parse(Console.ReadLine());
            if(liczba % 2 == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Liczba {liczba} jest parzysta");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Liczba {liczba} nie jest parzysta");
            }
            Console.ReadKey();
        }
    }
}
