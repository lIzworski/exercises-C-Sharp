using System;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Odcinek o1 = new Odcinek(new Punkt(2, 4), new Punkt(3, 5));
            o1.Wypis();
            Console.WriteLine(o1.Dlugosc());

            
        }
    }
}
