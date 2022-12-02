using System.Net.NetworkInformation;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice i1 = new Invoice( new DateOnly(2022,09,15), "Abdul WisiMuLach'a", "Pasterz Szawel Nasrallah");

            i1.AddNewItem(new Item(666, "Satan's bible", 100, 12));
            i1.AddNewItem(new Item(666, "Satan's bible", 100, 12));
            i1.AddNewItem(new Item(777, "Win-tomat", 1000, 150));
            i1.AddNewItem(new Item(634, "Goat for my muslim firend", 240, 77));
            i1.AddNewItem(new Item(323, "Best goat", 200, 34));
            i1.AddNewItem(new Item(346, "Few goats to another muslim friends", 1000, 420));
            i1.AddNewItem(new Item(333, "Black goat destined for a certain ritual", 666, 0));     
            
            Invoice i2 = new Invoice( new DateOnly(2022,09,15), "Abdul WisiMuLach'a", "Pasterz Szawel Nasrallah");

            i2.AddNewItem(new Item(213, "Holu church of Super Holy Spagetti GOD", 77, 11));
            i2.AddNewItem(new Item(244, "I Love Bolognese", 10, 3));
            i2.AddNewItem(new Item(564, "I realy like pasta", 10, 2));
            i2.AddNewItem(new Item(844, "How to create a Spagetti GOD from pasta", 7, 1));
            i2.AddNewItem(new Item(383, "Spegetti GOD give mi best pasta", 18, 5));
            i2.AddNewItem(new Item(236, "Olny real God is a Pasta GOD", 11, 2));
            i2.AddNewItem(new Item(432, "My GoD make my not hungry", 14, 1));
            
            i1.ToString();
            i2.ToString();
            Console.WriteLine("Dodawanie");
            Invoice i3 = i1 + i2;
            i3.ToString();

            Console.WriteLine("Odejmowanie");
            Invoice i4 = i1 - i1;
            i4.ToString();

            Console.WriteLine(i1 < i2);
            Console.WriteLine(i1 > i2);
            Console.WriteLine(i1 <= i2);
            Console.WriteLine(i1 >= i2);
            Console.WriteLine(i1 == i2);
            Console.WriteLine(i1 != i2);

            Invoice i5 = i2 & i4;

            i5.ToString();
        }
    }
}