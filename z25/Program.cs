
namespace Zadanie_IV_0._1
{
    public class Program
    {
         static void Main(string[] args)
        {
            Ciezarowy d2 = new Ciezarowy("Iveco", 4.2, 200000, "Pis Piotr", 12200, 20000);
            Ciezarowy d3 = new Ciezarowy("Man", 4.2, 200000, "Pis Piotr", 12200, 20000);
            Ciezarowy d4 = new Ciezarowy("Star", 4.2, 200000, "Pis Piotr", 12200, 20000);
            
            Osobowy o1 = new Osobowy("fiat", 1.6, 120000, "Jan", 5, 160);
            Osobowy o2 = new Osobowy("fsd", 1.6, 120000, "Jan", 5, 160);
            Osobowy o3 = new Osobowy("opel", 1.6, 120000, "Jan", 5, 160);
            Osobowy o4 = new Osobowy("Wv", 1.6, 120000, "Jan", 5, 160);

            //d2.Wypisz();
            //o2.Wypisz();
            Samochod.WypiszIloscSamochodow();


        }
    }

}

