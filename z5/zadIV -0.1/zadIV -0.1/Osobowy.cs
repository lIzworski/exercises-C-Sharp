using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadIV__0._1
{
    class Osobowy : Samochod
    {
        private int liczbaMiejsc;
        private int predkoscMaksymalna;


        public Osobowy(int liczbaMiejsc, int predkoscMaksymalna)
        {
            this.liczbaMiejsc = liczbaMiejsc;
            this.predkoscMaksymalna = predkoscMaksymalna;
            
        }
    }


}
