namespace zad1
{
    internal class Program
    {

        public struct Kwadrat
        {
            public void WyswietlWzor()
            {
                Console.WriteLine("P = a * a" );         
            }
        }

        static void Main(string[] args)
        {
            Kwadrat k = new Kwadrat();
            k.WyswietlWzor();
        }

    }
}