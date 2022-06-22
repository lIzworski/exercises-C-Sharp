using System;

namespace cw4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe");
            int liczba = int.Parse(Console.ReadLine());
            switch (liczba)
            {
                case 1:
                    Console.WriteLine("Poniedziałęk");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }
                

        }
    }
}
