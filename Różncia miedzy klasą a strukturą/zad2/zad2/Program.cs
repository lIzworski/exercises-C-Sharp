namespace zad2
{
    internal class Program
    {
        struct Number
        {
            public int number;
            //public void nIs20() {number = 20;}
        }
        static void Main(string[] args)
        {
            Number n = new Number();
            n.number = 20;
            Console.WriteLine(n.number);
        }

    }
}