namespace Zadanie_IV_0._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracownikEtatowy pe1 = new PracownikEtatowy("Krzysztof", "Jarzyna", "15.09.1958r.", "15.08.2003r.",3000,120,100,140,0.18); 
            PracownikEtatowy pe2 = new PracownikEtatowy("Jan", "Nowak", "12.03.1978r.", "15.08.2003r.",3100,120,100,140,0.18);
            PracownikGodzinowy pg1 = new PracownikGodzinowy("Bożydar", "Wymiotniew", "17.04.1991r.", "23.09.2019r.", 18, 160);
            PracownikGodzinowy pg2 = new PracownikGodzinowy("Maciej", "Burdzy", "11.02.1992r.", "24.01.2021r.", 15, 200);

            pe1.drukuj();
            pe2.drukuj();
            pg1.drukuj();
            pg2.drukuj();
        }
    }
}