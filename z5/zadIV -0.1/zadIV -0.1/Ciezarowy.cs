using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadIV__0._1
{
    class Ciezarowy : Samochod
    {
        private int ladownosc;
        private int dopuszczalnaMasaPrzyczepy;

        public int Ladownosc { get { return ladownosc; } set { ladownosc = value; } }
        private int DopuszczalnaMasaPrzyczepy { get { return dopuszczalnaMasaPrzyczepy; } set { dopuszczalnaMasaPrzyczepy = value; } }
        public Ciezarowy(int ladownosc, int dopuszczalnaMasaPrzyczepy)
        {
            this.ladownosc = ladownosc;
            this.dopuszczalnaMasaPrzyczepy = dopuszczalnaMasaPrzyczepy;
        }
    }
}
