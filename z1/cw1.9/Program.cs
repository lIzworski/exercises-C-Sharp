using System;

namespace cw1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zlicza i sumuje N kolejnych liczb");
            Console.WriteLine("Podaj N ");
            int i,suma = 0;
            int eN = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Pętla for");
            for(i = 0; i <= eN+10; i++)
            {
                if(i == eN)
                {
                    Console.WriteLine($"ilość wykorzystanych składników podczas dodawania to {(i-1)*2}");
                    Console.WriteLine($"Suma liczb od 0 do {eN-1} wynosi = {suma} ");
                    Console.WriteLine($"Dodawanie wykonało się {i-1} razy");
                    break;
                }
                suma += i;
            }
            i = 0;
            suma = 0;
            Console.WriteLine();
            Console.WriteLine("Pętla while");
            while (i < eN + 10)
            {
                if (i == eN)
                {
                    Console.WriteLine($"ilość wykorzystanych składników podczas dodawania to {(i - 1) * 2}");
                    Console.WriteLine($"Suma liczb od 0 do {eN-1} wynosi = {suma} ");
                    Console.WriteLine($"Dodawanie wykonało się {i-1} razy");
                    break;
                }
                suma += i;
                i++;
            }
            i = 0;
            suma = 0;
            Console.WriteLine();
            Console.WriteLine("Pętla do while");
            do
            {
                if (i == eN)
                {
                    Console.WriteLine($"ilość wykorzystanych składników podczas dodawania to {(i - 1) * 2}");
                    Console.WriteLine($"Suma liczb od 0 do {eN-1} wynosi = {suma} ");
                    Console.WriteLine($"Dodawanie wykonało się {i-1} razy");
                    break;
                }
                suma += i;
                i++;
            }
            while (i < eN + 10);          
        }
    }
}
