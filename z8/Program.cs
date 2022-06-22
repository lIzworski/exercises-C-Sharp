using System;

namespace II._5_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //j.
            Odcinek odc = new Odcinek(new Punkt(1,2), new Punkt(1,4));
            
            Console.WriteLine(odc.Dlugosc());
            odc.ZmienPoczątekOdcinka(2, 4);
            odc.ZmienKoniecOdcinka(2, 8);
            Console.WriteLine(odc.Dlugosc());
        }
    }
}
