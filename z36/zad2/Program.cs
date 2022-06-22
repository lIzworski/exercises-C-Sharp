using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj predkość w kilometrach na godzine");
            double predkosc = double.Parse(Console.ReadLine());
            Console.Write(" Predkość po przeliczeniu z km/h na m/s wynosi : ");
            double metrysek;
            metrysek = predkosc * 1000 / 3600;
            Console.WriteLine(metrysek);
        }
    }
}
