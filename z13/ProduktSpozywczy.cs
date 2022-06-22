using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV._2
{
    public class ProduktSpozywczy : Produkt
    {
        private DateTime dataWaznosci;
        private float waga;

        public DateTime DataWaznosci { get => dataWaznosci; set => dataWaznosci = value; }
        public float Waga { get => waga; set => waga = value; }

        public ProduktSpozywczy(string nazwa, double cena, string jednostkaMiary, string dataZakupu, double stawkaVAT, double marza,int rok, int miesiac, int dzien, float waga) : base( nazwa, cena, jednostkaMiary, dataZakupu,stawkaVAT,marza)
        {
            DataWaznosci = new DateTime(rok,miesiac,dzien); 
            Waga = waga;
        }
        public ProduktSpozywczy(Produkt p1, int rok, int miesiac, int dzien, float waga  ) :base(p1)
        {
            this.JednostkaMiary = p1.JednostkaMiary;
            DataWaznosci = new DateTime(rok,miesiac,dzien);
            Waga = waga;
        }
        public bool doSpozycia()
        {
            if(DataWaznosci > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool doSpozycia(DateTime d1)
        {
            if (d1 > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Wypisz()
        {
            Console.WriteLine($"Nazwa produktu: {Nazwa} Cena: {Cena:C2} Data Zakupu: {DataZakupu} Stawka Vat: {(StawkaVAT * 100):%} Jednostka Miary: {JednostkaMiary} Marza: {Marza:C2} Data ważności: {DataWaznosci} Waga: {Waga} ");
        }
    }
}
