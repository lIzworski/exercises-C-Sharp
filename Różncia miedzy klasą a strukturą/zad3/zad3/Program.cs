namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point1 = new Point2D() { x = 1, y = 1 };
            Point2D point2 = point1;
            point1.x = 2;
            point1.y = 2;
            Console.WriteLine("x=" + point1.x + " y=" + point1.y);
            Console.WriteLine("x=" + point2.x + " y=" + point2.y);
            Console.Read();
        }
    }

    public struct Point2D
    {
        public double x, y;
    }

}