using System;

namespace cw2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[][] tabliceTablic = new int[5][];
            int i = 0;
            int losowaLiczba;
            while (i < 5)
            {
                int liczbaTymczasowa;
                //losuje liczbe od 0 - 999
                losowaLiczba = rand.Next(0, 1000);

                Console.WriteLine($"Liczba w tabeli {i} = {losowaLiczba}");
                //zamieniam wylosowaną liczbe całkowitą w Stringa.
                string liczbaString = losowaLiczba.ToString();
                //Tworze tablcie Charów, do której wpisuje wcześniej stworzonego stringa.
                var tablicaCharLiczb = liczbaString.ToCharArray();
                //do zmiennej całkowitej przypisuje wartośc którą pozyskałem po sprawdzeniu długosci tablicy do której włorzyłem stringa.
                int dlugosc = tablicaCharLiczb.Length;
                //Tworze podtablice, której długość będzie równa tablicy charów.
                tabliceTablic[i] = new int[dlugosc];
                //W zależnosci od długości przypisuje tablcie do tablicy.
                if (dlugosc == 1)
                {
                    //Char przypisuje do int, przez co przekazuje się tam liczba w Unicode
                    liczbaTymczasowa = tablicaCharLiczb[0];
                    //Pod odjęciu 48 otrzymuje cyfre którą chciałem otrzymać.
                    tabliceTablic[i][0] = (liczbaTymczasowa - 48);
                    i++;
                }
                else if (dlugosc == 2)
                {
                    liczbaTymczasowa = tablicaCharLiczb[0];
                    tabliceTablic[i][0] = (liczbaTymczasowa - 48);
                    liczbaTymczasowa = tablicaCharLiczb[1];
                    tabliceTablic[i][1] = (liczbaTymczasowa - 48);
                    i++;
                }
                else if (dlugosc == 3)
                {
                    liczbaTymczasowa = tablicaCharLiczb[0];
                    tabliceTablic[i][0] = (liczbaTymczasowa - 48);
                    liczbaTymczasowa = tablicaCharLiczb[1];
                    tabliceTablic[i][1] = (liczbaTymczasowa - 48);
                    liczbaTymczasowa = tablicaCharLiczb[2];
                    tabliceTablic[i][2] = (liczbaTymczasowa - 48);
                    i++;
                }
            }
            for(i = 0; i< tabliceTablic.Length; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < tabliceTablic[i].Length; j++)
                {
                    Console.Write($"{tabliceTablic[i][j]} ");
                }
            }

            Console.ReadKey();
        }
    }
}
