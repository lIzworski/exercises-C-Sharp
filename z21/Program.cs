using System;

public class Test
{
    public static void Main()
    {
        double[] wspolrzedne = new double[] { 1,2,5 };
        Wektor w1 = new Wektor(3, wspolrzedne);
        w1.Show();
        Console.WriteLine();
        Console.WriteLine("Suma współrzędnych wektora wynosi: "+w1.Suma());
        Wektor w2 = new Wektor(3, wspolrzedne);
        w2.Show();
        Console.WriteLine();
        Wektor w3 = w1.add(w2);
        w3.Show();
    }
}
class Wektor
{
    private int Wymiar;
    private double[] Wspolrzedne;
    public Wektor(int n, double[] dane)
    {
        Wymiar = n;
        Wspolrzedne = new double[n];
        for (int i = 0; i < Wymiar; i++)
        {
            Wspolrzedne[i] = dane[i];
        }
    }
    public void Show()
    {
        Console.Write("[ ");
        for (int i = 0; i < Wymiar; i++)
        {
            Console.Write(Wspolrzedne[i]+" ");
        }
        Console.Write("]");
    }
    public double Suma()
    {
        double wynik = 0;
        for (int i = 0; i < Wymiar; i++)
        {
            wynik +=Wspolrzedne[i];
        }
        return wynik;
    }
    public Wektor add(Wektor w2)
    {
        double[] wynik = new double[Wymiar];
        for (int i = 0; i < Wymiar; i++)
        {
            wynik[i] = Wspolrzedne[i] + w2.Wspolrzedne[i];
        }
        return new Wektor(Wymiar, wynik);
    }
}