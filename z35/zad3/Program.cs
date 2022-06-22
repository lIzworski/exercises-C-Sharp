using System;

namespace zad3
{
    class Program
    {
		public static void Main(string[] args)
		{

			Console.WriteLine("Podaj cene netto");
			double netto = double.Parse(Console.ReadLine());
			Console.WriteLine("Podaj stawke VAT");
			double vat = double.Parse(Console.ReadLine());
			double brutto = netto + (vat * (netto / 100));
			Console.WriteLine("Cena brutto " + brutto + " zl");

		}
	}
}
