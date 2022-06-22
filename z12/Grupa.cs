using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._9_kurs
{
    public class Grupa
    {
        private int iloscOsob = 0;
        private Osoba[] osoby;
        public Osoba[] Osoby { get => osoby; set => osoby = value; }
        public int IloscOsob { get => iloscOsob; set => iloscOsob = value; }

        public void dodajOsobe(Osoba p1)
        {
            Osoby[iloscOsob] = p1;
            iloscOsob++;
        }
    }
}
