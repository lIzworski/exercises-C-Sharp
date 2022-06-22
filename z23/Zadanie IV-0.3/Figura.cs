using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_IV_0._3
{
    internal abstract class Figura
    {
        private string typFigury, kolorObramowania, kolorKrawedzi;
        public string TypFigury { get => typFigury; set => typFigury = value; }
        public string KolorObramowania { get => kolorObramowania; set => kolorObramowania = value; }
        public string KolorKrawedzi { get => kolorKrawedzi; set => kolorKrawedzi = value; }

        public Figura(string typFigury, string kolorObramowania, string kolorKrawedzi)
        {
            TypFigury = typFigury;
            KolorObramowania = kolorObramowania;
            KolorKrawedzi = kolorKrawedzi;
        }

        public abstract void pole();

        public abstract void obwod();

        public void naglowek() { Console.WriteLine($"Typ figury: {TypFigury}, kolor obramowania: {KolorObramowania}, kolor krawędzi: {KolorKrawedzi} "); }
    }
}
