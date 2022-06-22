using System;

namespace zad6___BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* PROGRAM BMI **************");
            Console.WriteLine();
            Console.WriteLine("Podaj swój wzrost w metrach : ");
            float wzrost = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wagę w kilogramach : ");
            float waga = float.Parse(Console.ReadLine());
            float BMI = waga / (wzrost * wzrost);
            if(BMI < 15)
            {
                Console.WriteLine("Wygłodzenie");
            }
            else if( BMI < 17.4)
            {
                Console.WriteLine("Wychudzenie");
            }
            else if (BMI < 18.5)
            {
                Console.WriteLine("Niedowaga");
            }
            else if (BMI < 24.9)
            {
                Console.WriteLine("Wartość prawidłowa");
            }
            else if (BMI < 29.9)
            {
                Console.WriteLine("nadwaga");
            }
            else if (BMI < 34.9)
            {
                Console.WriteLine("I Stopien otyłości");
            }
            else if (BMI < 39.9)
            {
                Console.WriteLine("II stopień otyłości");
            }
            else if (BMI > 40)
            {
                Console.WriteLine("III stopień otyłości");
            }
            Console.WriteLine(BMI);
        }
    }
}
