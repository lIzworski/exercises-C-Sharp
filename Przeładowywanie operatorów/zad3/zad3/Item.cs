using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Item
    {
        private int _positionNumber;
        private string _name = "";
        private double _netto;
        private double _vat;
        private double _brutto;
        private int _quatntity = 0;

        public int PositionNumber { get => _positionNumber; set => _positionNumber = value; }
        public string Name { get => _name.ToUpper(); set => _name = value; }
        public double Netto { get => _netto; set => _netto = value; }
        public double Vat { get => _vat; set => _vat = value; }
        public double Brutto { get => _brutto; set => _brutto = value; }
        public int Quatntity { get => _quatntity; set => _quatntity = value; }

        public Item(int positionNumber, string name, double netto, double vat )
        {
            Quatntity = 1;
            PositionNumber = positionNumber;
            Name = name;
            Netto = netto;
            Vat = vat;
            Brutto = Netto + Vat;
        }

        public new void ToString()
        {
            Console.WriteLine($"Nr.Poz: {PositionNumber}, Ilość: {Quatntity}, Nazwa: {Name}, Netto/szt: {Netto}zł, VAT/szt :{Vat}zł, Brutto :{Brutto}zł");
        }

    }
}
