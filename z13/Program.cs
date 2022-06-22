using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produkt p1 = new Produkt("Oliwa",3.20,"litr","15.12.2019r",23,1);
            ProduktSpozywczy ps1 = new ProduktSpozywczy("Jabol", 2.5, "litr", "12.09.1999", 23, 1, 2020, 12, 15, 3);
            ProduktSpozywczy ps2 = new ProduktSpozywczy(new Produkt(p1), 2022, 09, 12, 1);
            p1.Wypisz();
            Console.WriteLine();
            ps1.Wypisz();
            Console.WriteLine(ps1.doSpozycia());
            Console.WriteLine();
            ps2.Wypisz();
            Console.WriteLine(ps2.doSpozycia());


        } 
    }
}
