namespace zad1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            TimeExample t1 = new TimeExample(5, 5, 5);
            TimeExample t2 = new TimeExample(5, 5, 5);
            TimeExample t3 = new TimeExample(6, 6, 6);

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 < t3);
            Console.WriteLine(t1++);
            Console.WriteLine(t1--);

        }
    }
}