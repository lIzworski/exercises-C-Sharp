using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV._3
{
    public class Przelew :Transakcja
    {
        Konto kontoo;

        public Konto Kontoooo { get => kontoo; set => kontoo = value; }

        public Przelew(string dataRealizacji, string tytulem, double kwota, Konto k1) : base(dataRealizacji, tytulem, kwota)
        {
            Kontoooo = k1;
        }
        public new void InfoTransakcji()
        {
            if (Kwota > 0)
            {
                Console.WriteLine($"{DataRealizacji} wpłyneło {Kwota:C} tytułem: {Tytulem.ToUpper()}");

                Kontoooo.informacjeOKoncie();
                Console.WriteLine();
            }
            else if (Kwota < 0)
            {
                Console.WriteLine($"{DataRealizacji} wypłaciłeś {Kwota:C} tytułem: {Tytulem.ToUpper()}");
                Kontoooo.informacjeOKoncie();
                Console.WriteLine();
            }
            else { Console.WriteLine("Transakcja nieudana, brak podanej kwoty."); }

        }
    }
}
