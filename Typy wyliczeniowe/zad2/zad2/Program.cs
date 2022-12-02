namespace zad2
{
    class Program
    {
        enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday = 10,
            Friday,
            Saturday,
            Sunday
        };

        static void Main(string[] args)
        {
            Console.WriteLine((int)Day.Thursday);
        }
    }

}