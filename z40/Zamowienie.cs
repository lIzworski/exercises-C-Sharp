using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_II._7
{
    internal class Zamowienie
    {
        private string dataRealizacji;
        private string nazwaKlienta;
        private int nrPozycji = 0;
        private Sprzedaz[] zamowienia;

        public string DataRealizacji { get { return dataRealizacji; } set { dataRealizacji = value; } }
        public string NazwaKlienta { get { return nazwaKlienta; } set { nazwaKlienta = value; } }

        public Zamowienie (string DataRealizacji, string NazwaKlienta)
        {
            this.DataRealizacji = DataRealizacji;
            this.NazwaKlienta = NazwaKlienta;
            zamowienia = new Sprzedaz[20];
        }

        public void dodajPozycje(Sprzedaz sell)
        {
            zamowienia[nrPozycji] = sell;
            nrPozycji++;
        }
        public void wydrykujCalaListeZakupow()
        {
            
            double suma = 0;
            for(int i = 0; i < nrPozycji; i++)
            {
                Sprzedaz tmp = new Sprzedaz("test",1,1);
                tmp.kopiujObiekt(zamowienia[i]);
                //tmp = zamowienia[i];
                tmp.sprzedany();
                suma = suma + (tmp.Cena * tmp.Ilosc);

            }
            Console.WriteLine($"\nDo zapłaty w sumie: {suma:C}");
        }
        
    }
}
