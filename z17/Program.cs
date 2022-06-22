using System;

namespace ZadVII_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 4;
            Swap<int>(ref x, ref y);
            Console.WriteLine("x= "+x);
            Console.WriteLine("y= "+y);

            string slowo1 = "Pies";
            string slowo2 = "Kot";
            Swap<string>(ref slowo1, ref slowo2);
            Console.WriteLine("slowo1 = "+slowo1);
            Console.WriteLine("slowo2 = " + slowo2);
         }
    static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
    }
}
