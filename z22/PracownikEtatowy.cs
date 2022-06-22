using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_IV_0._4
{
    internal class PracownikEtatowy :Pracownik
    {
        private double pensjaBrutto;
        private double skladkaEmerytalna;
        private double skladkaChorobowa;
        private double skladkaRentowa;
        private double podatek;
        

        public PracownikEtatowy(string imie, string nazwisko, string dataUrodzenia, string dataZatrudnienia, double pensjaBrutto, double skladkaEmerytalna, double skladkaChorobowa, double skladkaRentowa, double podatek) :base(imie, nazwisko, dataUrodzenia, dataZatrudnienia)
        {
            PensjaBrutto = pensjaBrutto;
            SkladkaEmerytalna = skladkaEmerytalna;
            SkladkaChorobowa = skladkaChorobowa;
            Podatek = podatek;
            SkladkaRentowa = skladkaRentowa;
            DataZatrudnienia = dataZatrudnienia;
        }

        public double PensjaBrutto { get => pensjaBrutto; set => pensjaBrutto = value; }
        public double SkladkaEmerytalna { get => skladkaEmerytalna; set => skladkaEmerytalna = value; }
        public double SkladkaChorobowa { get => skladkaChorobowa; set => skladkaChorobowa = value; }
        public double SkladkaRentowa { get => skladkaRentowa; set => skladkaRentowa = value; }
        public double Podatek { get => podatek; set => podatek = value; }

        public double pensjaNetto()
        {
            double pensjaNetto = (PensjaBrutto - SkladkaEmerytalna - SkladkaChorobowa - SkladkaRentowa) - (PensjaBrutto * Podatek); 

            return pensjaNetto;
        }
        public override void drukuj()
        {
            base.drukuj();
            Console.WriteLine($"pensja Brutto: {PensjaBrutto}");
            Console.WriteLine($"pensja Netto: {pensjaNetto()}\n");
        }
    }
}
