using System;

namespace II._5_01 
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
            //b.
            Pudelko p1 = new Pudelko(); 
            p1.szerokosc = 10;
            p1.wysokosc = 10;
            p1.glebokosc = 10;
            p1.kolor = "biały";

            Pudelko p2 = new Pudelko();
            p2.szerokosc = 30;
            p2.wysokosc = 30;
            p2.glebokosc = 30;
            p2.kolor = "niebieski";
           
            Console.WriteLine($"Pudełko Pierwsze Kolor: {p1.kolor} Wysokość: {p1.wysokosc} Szerokość: {p1.szerokosc} Głębokość: {p1.glebokosc}");
            Console.WriteLine($"Pudełko Drugie   Kolor: {p2.kolor} Wysokość: {p2.wysokosc} Szerokość: {p2.szerokosc} Głębokość: {p2.glebokosc}");

            //f.
            Pudelko pudelkoA = new Pudelko(15,15,15,"szary");
            //g.
            Pudelko pudelkoB = new Pudelko();
            pudelkoB = pudelkoA;
            //h. 
            pudelkoB.szerokosc = 40;
            Console.WriteLine(pudelkoA.szerokosc);
            //j.
            Pudelko pudelkoC = new Pudelko(pudelkoB);
            //k.
            pudelkoB.szerokosc = 2;
            Console.WriteLine($"pudelkoA szerokosc: {pudelkoA.szerokosc}");
            Console.WriteLine($"pudelkoB szerokosc: {pudelkoB.szerokosc}");
            Console.WriteLine($"pudelkoC szerokosc: {pudelkoC.szerokosc}");
           */
            Pudelko p1 = new Pudelko(1,2,3,"Kolorowe");
            Pudelko p2 = new Pudelko();
            Pudelko p3 = new Pudelko(p1);

            Console.WriteLine($"Objętość pudełka p1: {p1.ObjetoscPudelka()}");
            Console.WriteLine($"Objętość pudełka p2: {p2.ObjetoscPudelka()}");
            Console.WriteLine($"Objętość pudełka p2: {p3.ObjetoscPudelka()}");
            Console.WriteLine();
            Console.WriteLine($"Ilość utworzonych pudełek: {Pudelko.getIlePudelek()}");

        }
    }
}