namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Punkt3D> list = new List<Punkt3D>();
            list.Add(new Punkt3D(0, 0, 0));
            list.Add(new Punkt3D(4, 0, 0));
            list.Add(new Punkt3D(4, 0, 4));
            list.Add(new Punkt3D(0, 4, 4));
            list.Add(new Punkt3D(0, 4, 0));
            list.Add(new Punkt3D(4, 4, 0));
            list.Add(new Punkt3D(4, 4, 4));
            list.Add(new Punkt3D(0, 0, 4));
        }
    }
}