using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadIV__0._1
{
    class Samochod
    {
        private string _marka;
        private double pojemnoscSilnika;
        private int przebieg;
        private string wlasciciel;

        public Samochod(string marka, double pojemnoscSilnika, int przebieg, string wlasciciel)
        {
            this.marka = marka;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.przebieg = przebieg;
            this.wlasciciel = wlasciciel;
        }


    }
}
