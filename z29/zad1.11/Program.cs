using System;

namespace zad1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwaKarty;
            int suma = 0;
            int i = 0;
            Console.WriteLine("Podaj nazwe karty - z przedziału od dziewiątki do asa");
            Console.WriteLine("Używaj polskich znaków, oraz pisz małymi literami.");
            Console.WriteLine();
            while (i < 5)
            {
                Console.WriteLine($"Podaj nazwe {i+1} karty");
                nazwaKarty = Console.ReadLine();
                switch (nazwaKarty)
                {
                    case "dziewiątka":
                        suma += 0;
                        i++;
                        break;
                    case "walet":
                        suma += 2;
                        i++;
                        break;
                    case "dama":
                        suma += 3;
                        i++;
                        break;
                    case "król":
                        suma += 4;
                        i++;
                        break;
                    case "dziesiątka":
                        suma += 10;
                        i++;
                        break;
                    case "as":
                        suma += 11;
                        i++;
                        break;
                    default:
                        Console.WriteLine("Nie ma karty o tej nazwie. Spróbuj jeszcze raz.");
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Łączna watrość kart którę podałeś wynosi {suma} pkt");
        }
    }
}
