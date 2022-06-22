using System;
using System.Collections.Generic;

namespace ZadVII_04
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var listaInt = new List<int>();
            listaInt.Add(1);
            listaInt.Add(2);
            listaInt.Add(3);
            listaInt.Add(4);
            listaInt.Add(5);
            listaInt.Add(6);
            foreach (int i in listaInt)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();

            listaInt.Insert(4, 666);
            listaInt.RemoveAt(2);
            listaInt.RemoveAt(5);

            foreach (int i in listaInt)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
            listaInt.Sort();
            foreach (int i in listaInt)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
