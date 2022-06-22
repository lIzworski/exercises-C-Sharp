using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._9_kurs
{
    internal class Kurs
    {
        private string nazwaKursu;
        private int liczbaGodzin;
        private string osobaProwadzaca;

        private static Grupa[] grupy;

        private int i = 0;

        public string NazwaKursu { get => nazwaKursu; set => nazwaKursu = value; }
        public int LiczbaGodzin { get => liczbaGodzin; set => liczbaGodzin = value; }
        public string OsobaProwadzaca { get => osobaProwadzaca; set => osobaProwadzaca = value; }
        public static Grupa[] Grupy { get => grupy; set => grupy = value; }

        public Kurs(string nazwaKursu, int liczbaGodzin, string osobaProwadzaca)
        {
            NazwaKursu = nazwaKursu;
            LiczbaGodzin = liczbaGodzin;
            OsobaProwadzaca = osobaProwadzaca;
        }
        //Dodawania grupy
        public void dodajGrupe()
        {
            Grupy[i] = new Grupa();
            i++;
        }
        public void wyswietlGrupe(int index, Grupa g1)
        {
            Console.WriteLine($"Grupa[{index}] składa się z {g1.IloscOsob} osób. ");
            for(int j = 0; j < g1.IloscOsob-1; j++)
            {
                Console.WriteLine($"{j+1}: {g1.Osoby[j]}");
            }
        }
    }
}
