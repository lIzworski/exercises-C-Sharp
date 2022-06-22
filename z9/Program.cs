using System;

namespace II._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produkt o1 = new Produkt();
            Produkt produkt = new Produkt("kij",2,"mb","18.04.2022r",0.23, 1.77);
            produkt.Wypisz();
            produkt.Clone(o1);
            Console.WriteLine();
            produkt.Wypisz();

            
            
        }
    }
}
