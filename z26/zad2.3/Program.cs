using System;

namespace zad2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program do generowania tabliczki mnożenia, o wymiarach a i b, podanych przez użytkownika.");
            Console.WriteLine("Podaj wartość liczby a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość liczby b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            int[,] tabliczkaMnozenia = new int[a, b];
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b ; j++)
                {
                    tabliczkaMnozenia[i, j] = (i+1) * (j+1);
                }
            }

            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    Console.Write(tabliczkaMnozenia[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
