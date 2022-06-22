
namespace Zadanie_IV_0._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Trojkat t1 = new Trojkat(3, 4, 5, "Trójkąt", "Szary", "Szary");
            Trojkat t2 = new Trojkat(5, 8, 9, "Trójkąt", "Niebieski", "Niebieski");
            Console.WriteLine($"Trójkąt {t1.KolorKrawedzi}");
            t1.pole();
            t1.obwod();
            Console.WriteLine($"\nTrójkąt {t2.KolorKrawedzi}");
            t2.pole();
            t2.obwod();
            Prostokat p1 = new Prostokat(4, 6, "Prostokąt", "Różowy", "Beżowy");
            Prostokat p2 = new Prostokat(6, 9, "Prostokąt", "Żółty", "Żółty");
            Console.WriteLine($"\nProstokąt {p1.KolorKrawedzi}");
            p1.pole();
            p1.obwod();
            Console.WriteLine($"\nProstokąt {p2.KolorKrawedzi}");
            p2.pole();
            p2.obwod();
        }
    }
}
