using System;

namespace ZadVII_01
{

    internal class Program
    {
        static void Main(string[] args)
        {
            KlasGeneryczna<int> p1 = new KlasGeneryczna<int>(15);
            p1.Wypisz();
        }
        public class KlasGeneryczna<T>
        {

            private T pole;

            public KlasGeneryczna(T pole)
            {
                Pole = pole;
            }

            public T Pole { get { return pole; } set { pole = value; } }

            public void Wypisz()
            {
                Console.WriteLine($"Nazwa Typu: {Pole.GetType()}");
                Console.WriteLine($"wartość pola: {pole}");
                Console.WriteLine($"wartość własciwosci: {Pole}");
            }
        }
    }
}
