using System;

namespace zad2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string zdanie = "Ala ma kota, a wojetek nie.";
            
            string[] slowa = zdanie.Split(' ');

            foreach (var a in slowa)
            {
                Console.WriteLine(a.Trim('.',','));
            }
            
        }
    }
}
