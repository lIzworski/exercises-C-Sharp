using System;

namespace cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pudelko boxx = new Pudelko();

            Pudelko box1 = new Pudelko(10, 10, 10, "szary");
            Pudelko box2 = new Pudelko(20, 20, 20, "niebieski");

            //box2.Wypisz();

            Pudelko box3 = new Pudelko(box1);

            box1.Wypisz();
            Console.WriteLine();
            box3.Wypisz();

            box1.setSzerokosc(15);
            Console.WriteLine("Po modyfikacji\n");
            box1.Wypisz();
            Console.WriteLine();
            box3.Wypisz();
            Console.WriteLine();
            Console.WriteLine("Objętność" );
            Console.WriteLine(box3.ObliczObjetosc());

            Console.WriteLine($"Ilość pudełek = {Pudelko.getIlosc()}");

            box2.Kolor = "Różowy";
            Console.WriteLine();
            box2.Wypisz();
        }
    }
}
