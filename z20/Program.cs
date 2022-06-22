using System;

namespace Zadanie_V_0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p1  = new Program();
            LWymierna lw1 = new LWymierna(2,4);
            LWymierna lw2 = new LWymierna(1,3);
            LWymierna lw3 = new LWymierna(1,2);

            Console.WriteLine("Dodawanie");
            lw1.dodajUlamek(lw3);
            lw1.wypiszUlamek();
            Console.WriteLine("Odejmowanie");
            lw2.odejmijUlamek(lw3);
            lw2.wypiszUlamek();
        }
        public struct LWymierna
        {
            private int licznik;
            private int mianownik;

            public int Licznik { get { return licznik; } set { licznik = value; } }
            public int Mianownik { get { return mianownik; }set{mianownik = value; }}

            public LWymierna(int licznik, int mianownik) : this()
            {
                Licznik = licznik;
                if(mianownik == 0)
                {
                Mianownik = 1;
                }
                else
                {
                    Mianownik = mianownik;
                }
            }

            public LWymierna(int licznik) : this()
            {
                Licznik = licznik;
                Mianownik = 1;
            }

            public void wczytajUlamek()
            {
                Console.WriteLine("Podaj wartość Licznika");
                Licznik = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartość Mianownika");
                Mianownik = int.Parse(Console.ReadLine());
               if(Mianownik == 0) { Mianownik = 1; }
            }
            public void wypiszUlamek()
            {
                Console.Write($"{Licznik}/{Mianownik}");
                if(Licznik >= Mianownik && Licznik % Mianownik == 0 ) 
                {
                    int ileRazyWiekszyLiczebnik = Licznik / Mianownik;
                    int wynik =  1 * ileRazyWiekszyLiczebnik;
                    Console.WriteLine($" = {wynik}");


                }
                Console.WriteLine();
            }
            public void dodajUlamek(LWymierna B)
            {
                int TmpLicznik;
                int TmpMianownik;
                int LicznikA =  this.Licznik;
                int MianownikA = this.Mianownik;
                int LicznikB = B.Licznik;
                int MianownikB = B.Mianownik;

                if(MianownikA == MianownikB)
                {
                    TmpLicznik = this.Licznik += B.Licznik;
                    TmpMianownik = this.Mianownik;

                }
                else
                {

                    LicznikA = this.Licznik * B.Mianownik;
                    LicznikB = B.Licznik * this.Mianownik;
                    TmpLicznik = LicznikA + LicznikB;
                    TmpMianownik = this.Mianownik * B.Mianownik;

                    this.Licznik = TmpLicznik;
                    this.Mianownik = TmpMianownik;
                }
            }
            public void odejmijUlamek(LWymierna B)
            {
                int TmpLicznik;
                int TmpMianownik;
                int LicznikA = this.Licznik;
                int MianownikA = this.Mianownik;
                int LicznikB = B.Licznik;
                int MianownikB = B.Mianownik;

                if (MianownikA == MianownikB)
                {
                    TmpLicznik = this.Licznik -= B.Licznik;
                    TmpMianownik = this.Mianownik;

                }
                else
                {

                    LicznikA = this.Licznik * B.Mianownik;
                    LicznikB = B.Licznik * this.Mianownik;
                    TmpLicznik = LicznikA - LicznikB;
                    TmpMianownik = this.Mianownik * B.Mianownik;

                    this.Licznik = TmpLicznik;
                    this.Mianownik = TmpMianownik;
                }
            }
        }
    }
}
