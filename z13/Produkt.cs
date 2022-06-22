using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV._2
{
    public class Produkt
    {
        private string nazwa;
        private double cena;
        private string jednostkaMiary;
        private string dataZakupu;
        private double stawkaVAT;
        private double marza;

        public Produkt(string nazwa, double cena, string jednostkaMiary, string dataZakupu, double stawkaVAT, double marza)
        {
            Nazwa = nazwa;
            Cena = cena;
            JednostkaMiary = jednostkaMiary;
            DataZakupu = dataZakupu;
            StawkaVAT = stawkaVAT;
            Marza = marza;
        }
        public Produkt(Produkt p1)
        {
            this.Nazwa = p1.Nazwa;
            this.Cena = p1.Cena;
            this.DataZakupu = p1.DataZakupu;
            this.StawkaVAT = p1.StawkaVAT;
            this.Marza = p1.Marza;
            this.JednostkaMiary = p1.JednostkaMiary;
        }
        public Produkt( )
        {
            Console.Write("Podaj nazwe produktu: ");
            Nazwa = Console.ReadLine();
            Console.Write("Podaj cenę produktu: ");
            Cena = double.Parse(Console.ReadLine());
            Console.Write("Podaj jednostkę miary: ");
            JednostkaMiary = Console.ReadLine();
            Console.Write("Podaj date zakupu produktu: ");
            DataZakupu = Console.ReadLine();
            Console.Write("Podaj stawkę VAT: ");
            StawkaVAT = double.Parse(Console.ReadLine());
            Console.Write("Podaj marzę produktu: ");
            Marza = double.Parse(Console.ReadLine());
        }
        public string Nazwa { get { return nazwa; } set { nazwa = value; } }
        public double Cena { get { return cena; } set { cena = value; } }
        public string DataZakupu { get { return dataZakupu; } set { dataZakupu = value; } }
        public double StawkaVAT { get { return stawkaVAT; } set { stawkaVAT = value; } }
        public string JednostkaMiary { get { return jednostkaMiary; } set { jednostkaMiary = value; } }
        public double Marza { get { return marza; } set { marza = value; } }

        public virtual void Wypisz()
        {
            Console.WriteLine($"Nazwa produktu: {Nazwa} Cena: {Cena:C2} Data Zakupu: {DataZakupu} Stawka Vat: {(StawkaVAT*100):%} Jednostka Miary: {JednostkaMiary} Marza: {Marza:C2} ");
        }
        public void Clone(Produkt p1)
        {
            this.Nazwa = p1.Nazwa;
            this.Cena = p1.Cena;
            this.DataZakupu = p1.DataZakupu;
            this.StawkaVAT = p1.StawkaVAT;
            this.Marza = p1.Marza;
            this.JednostkaMiary = p1.JednostkaMiary;
        }
    }
}
