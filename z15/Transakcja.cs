using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV._3
{
    public class Transakcja
    {
        private string dataRealizacji;
        private string tytulem;
        private double kwota;
        
        public string DataRealizacji { get { return dataRealizacji; } set { dataRealizacji = value; } }
        public string Tytulem { get { return tytulem; } set { tytulem = value; } }
        public double Kwota { get { return kwota; } set { kwota = value; } }

        public Transakcja(string dataRealizacji, string tytulem, double kwota)
        {
            DataRealizacji = dataRealizacji;
            Tytulem = tytulem;
            Kwota = kwota;
        }
        public void InfoTransakcji()
        {
            if(Kwota > 0)
            {
                Console.WriteLine($"{DataRealizacji} wpłyneło {Kwota:C} tytułem: {Tytulem.ToUpper()}");
            }
            else if(Kwota < 0)
            {
                Console.WriteLine($"{DataRealizacji} wypłaciłeś {Kwota:C} tytułem: {Tytulem.ToUpper()}");
            }
            else { Console.WriteLine("Transakcja nieudana, brak podanej kwoty."); }  
        }

    }
}
