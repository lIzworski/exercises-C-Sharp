using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._8_Konto
{
    internal class Konto
    {
        private string nrKonta;
        private string nazwaWlasciciela;
        private string dataUtworzeniaKonta;
        private Transakcja[,] transakcje = new Transakcja[500, 1000];
        private int nrTransakcjiDodatniej = 0;
        private int nrTransakcjiUjemnej = 0;
        private double sumaPrzelewowWchodzacych = 0;
        private double sumaPrzelewowWychodzacych = 0;
        private double bilans = 0;

        public string NrKonta { get { return nrKonta; } set { nrKonta = value; } }
        public string NazwaWlasciciela { get { return nazwaWlasciciela; } set { nazwaWlasciciela = value; } }
        public string DataUtworzeniaKonta { get { return dataUtworzeniaKonta; } set { dataUtworzeniaKonta = value; } }
        public Transakcja[,] Transakcje { get { return transakcje; } set { transakcje = value; } }
        public int NrTransakcjiDodatniej { get { return nrTransakcjiDodatniej; } set { nrTransakcjiDodatniej = value; } }
        public int NrTransakcjiUjemnej { get { return nrTransakcjiUjemnej; } set { nrTransakcjiUjemnej = value; } }
        public double SumaPrzelewowWchodzacych { get { return sumaPrzelewowWchodzacych; } set { sumaPrzelewowWchodzacych = value; } }
        public double SumaPrzelewowWychodzacych { get { return sumaPrzelewowWychodzacych; } set { sumaPrzelewowWychodzacych = value; } }
        public double Bilans { get { return bilans; } set { bilans = value; } }

        public Konto(string nrKonta, string nazwaWlasciciela, string dataUtworzeniaKonta)
        {
            NrKonta = nrKonta;
            NazwaWlasciciela = nazwaWlasciciela;
            DataUtworzeniaKonta = dataUtworzeniaKonta;
        }

        public void dodajTransakcje(Transakcja t1)
        {
            if(t1.Kwota > 0)
            {
                transakcje[0, NrTransakcjiDodatniej] = t1;
                NrTransakcjiDodatniej++;
                SumaPrzelewowWchodzacych += t1.Kwota; 
            }
            else if(t1.Kwota < 0)
            {
                transakcje[1, NrTransakcjiUjemnej] = t1;
                NrTransakcjiUjemnej++;
                SumaPrzelewowWychodzacych += t1.Kwota;
            }
            else { Console.WriteLine("Nie można wykonać transakcji nie podając jej kwoty."); }
            Bilans = Bilans + t1.Kwota;
        }

        public void sprawdzStanKonta()
        {
            Console.WriteLine($"Na twoim koncie znajduje się: {Bilans:C} ");
        }


        public void informacjeOKoncie()
        {
            Console.Write($"Nr konta:{NrKonta}, Własciciel: {NazwaWlasciciela}, Data utworzenia: {DataUtworzeniaKonta}"); 
            if(NrTransakcjiDodatniej > 0 || NrTransakcjiUjemnej > 0)
            {
                Console.WriteLine($", Stan konta : {Bilans:C}");
            }
            else { Console.WriteLine(); }
        }
        public override string ToString()
        {
            return $"Nr konta:{NrKonta}, Własciciel: {NazwaWlasciciela}, Data utworzenia: {DataUtworzeniaKonta}"; 
        }

    }
}
