using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._5_01
{
    internal class Pudelko
    {   /*
        //a.
        public int szerokosc;
        public int wysokosc;
        public int glebokosc;
        public string kolor;
        */
        //l.
        private int szerokosc;
        private int wysokosc;
        private int glebokosc;
        private string kolor;
        //o.
        private static int ilePudelek = 0;
        //c.
        //d. Nie można utworzyć obiektu nie podając argumentów, nie posiadając konstrukkotra bezargumentowego.
        public Pudelko(int szerokosc, int wysokosc, int glebokosc, string kolor)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.glebokosc = glebokosc;
            this.kolor = kolor;
            ilePudelek++;
        }
        //e.
        public Pudelko() { ilePudelek++; }
        //i.
        public Pudelko(Pudelko p1)
        {
            this.szerokosc = p1.szerokosc;
            this.wysokosc = p1.wysokosc;
            this.glebokosc = p1.glebokosc;
            this.kolor = p1.kolor;
            ilePudelek++;
        }
        //m.
        public void setWysokosc(int wysokosc) { this.wysokosc = wysokosc; }
        public void setGlebokosc(int glebokosc) { this.glebokosc = glebokosc; }
        public void setSzerokosc(int szerokosc) { this.szerokosc = szerokosc; }

        //n.
        public int ObjetoscPudelka()
        {
            return szerokosc * wysokosc * glebokosc;
        }
        //p.
        public static int getIlePudelek()
        {
            return ilePudelek;
        }
    }
}
