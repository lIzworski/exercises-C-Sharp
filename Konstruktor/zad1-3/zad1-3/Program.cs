namespace zad1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pies p1 = new Pies("Rocky", 7);
            Pies p2 = new Pies("Sone", 7,"Chow Chow");
            Pies p3 = new Pies("HotDog", 7,"rodwailer");
            Pies p4 = new Pies("Pies", 7, "Ciualua");
            Pies p5 = new Pies("Pies2", 7);
            Pies p6 = new Pies("RudyPies", 7);
            Pies p7 = new Pies("białyPies", 7,"Rablador");

            Pies.HowManyDogs();


        }
    }
}