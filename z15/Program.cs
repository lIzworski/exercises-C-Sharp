namespace IV._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Przelew p1 = new Przelew("15.12.1999", "Usługi", 300, new Konto("1234567890", "Dżesika", "1992.09.12r"));
            p1.InfoTransakcji();
            Przelew p2 = new Przelew("11.11.1991", "Montaż", -200, new Konto("0987654321", "Marian", "1910.01.11r"));
            p2.InfoTransakcji();
        }
    }
}