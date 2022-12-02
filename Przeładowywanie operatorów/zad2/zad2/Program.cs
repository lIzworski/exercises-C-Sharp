namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(5, 5);
            m1.FillTheMatrix();
            Matrix m2 = new Matrix(5, 5);
            m2.FillTheMatrix();
            Matrix m3;
            Matrix m4;
            Matrix m5;
            Console.WriteLine("\nMacierz 1");
            m1.ToString();
            Console.WriteLine("\nMacierz 2");
            m2.ToString();
            Console.WriteLine("\nDodawanie Macierzy");
            m3 = m1 + m2;
            m3.ToString();
            Console.WriteLine("\nOdejmowanie Macierzy");
            m4 = m1 - m2;
            m4.ToString();
            Console.WriteLine("\nMnożenie macierzy nr 1 x 2");
            m5 = m1 * 2;
            m5.ToString();

        }
    }
}