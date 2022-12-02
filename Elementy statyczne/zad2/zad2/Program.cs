namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StaticClass.TimeConventedToPL("12.12.2002");
            StaticClass.TimeConventedToPL("17.12.2002");
            StaticClass.TimeConventedToPL("1.2015");
            StaticClass.TimeConventedToPL("19.012051");
            StaticClass.howManyFailsAndPassed();
        }
    }
}