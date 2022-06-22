using System;

namespace zad1._10
{
    class Program
    {
        public void liczbaNaście(char a)
        {
            if (a == '0')
            {
                Console.Write("Dziesięć ");
            }
            else if (a == '1')
            {
                Console.Write("Jedynaście ");
            }
            else if (a == '2')
            {
                Console.Write("Dwanaście ");
            }
            else if (a == '3')
            {
                Console.Write("Trzynascie ");
            }
            else if (a == '4')
            {
                Console.Write("Czternascie ");
            }
            else if (a == '5')
            {
                Console.Write("Piętnaście ");
            }
            else if (a == '6')
            {
                Console.Write("Szestnaście ");
            }
            else if (a == '7')
            {
                Console.Write("Siedemnaście ");
            }
            else if (a == '8')
            {
                Console.Write("Osiemnaście ");
            }
            else if (a == '9')
            {
                Console.Write("Dziewietnaście ");
            }
        }
        public void liczbaJednostek(char a)
        {
            if (a == '0')
            {
                Console.Write("Zero ");
            }
            else if (a == '1')
            {
                Console.Write("Jeden ");
            }
            else if (a == '2')
            {
                Console.Write("Dwa ");
            }
            else if (a == '3')
            {
                Console.Write("Trzy ");
            }
            else if (a == '4')
            {
                Console.Write("Cztery ");
            }
            else if (a == '5')
            {
                Console.Write("Pięć ");
            }
            else if (a == '6')
            {
                Console.Write("Sześć ");
            }
            else if (a == '7')
            {
                Console.Write("Siedem ");
            }
            else if (a == '8')
            {
                Console.Write("Osiem ");
            }
            else if (a == '9')
            {
                Console.Write("Dziewięć");
            }
        }
        public void liczbaDziesiątek(char a)
        {
            if (a == '2')
            {
                Console.Write("Dwadzieścia ");
            }
            else if (a == '3')
            {
                Console.Write("Trzydzieści ");
            }
            else if (a == '4')
            {
                Console.Write("Czterdzieści ");
            }
            else if (a == '5')
            {
                Console.Write("Pięćdziesiąt ");
            }
            else if (a == '6')
            {
                Console.Write("Sześćdziesiąt ");
            }
            else if (a == '7')
            {
                Console.Write("Siedemdziesiąt ");
            }
            else if (a == '8')
            {
                Console.Write("Osiemdziesiąt ");
            }
            else if (a == '9')
            {
                Console.Write("Dziewięćdziesiąt ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program do generowania słownie wyrażonej wartości dwucyfrowej liczby całkowitej");
            Console.WriteLine();
            //Genereuje losową liczbe od 0 do 99.
            Random rand = new Random();
            int liczba = rand.Next(0, 100);
            Console.WriteLine($"Wylosowana liczba to: {liczba} ");
            Console.WriteLine();
            string juzPrawieSlownieLiczba;
            // Zmieniam liczbe na String'a
            juzPrawieSlownieLiczba = liczba.ToString();
            // wkładam stringa do tablicy, dziląc go na pojedyńcze znaki.
            var charArray = juzPrawieSlownieLiczba.ToCharArray();
            int dlugoscTablicy = charArray.Length;
            Program p1 = new Program();

            if(dlugoscTablicy == 1)
            {
                p1.liczbaJednostek(charArray[0]);
                Console.WriteLine();
            }
            if(dlugoscTablicy == 2)
            {
                if(charArray[0] == '1')
                {
                    p1.liczbaNaście(charArray[1]);
                    Console.WriteLine();
                }
                else
                {
                    if(charArray[1] == '0' && charArray[0] != '1')
                    {
                        p1.liczbaDziesiątek(charArray[0]);
                        Console.WriteLine();
                    }
                    else
                    {
                        p1.liczbaDziesiątek(charArray[0]);
                        p1.liczbaJednostek(charArray[1]);
                        Console.WriteLine();
                    }

                }
            }
  
        }
    }
}
