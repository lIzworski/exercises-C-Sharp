using System;

namespace II._8_Konto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konto k1 = new Konto("3338822255", "Władysław Trzesiedzida", "Anno domini 23.05.1564r ");

            k1.dodajTransakcje(new Transakcja("03.06.1579", "Zakup Papieru do notowania", -15));
            k1.dodajTransakcje(new Transakcja("03.06.1579", "Zakup Papieru do innych czynności", -10));
            k1.dodajTransakcje(new Transakcja("5.3.1580", "Piwo", -2.5));
            k1.dodajTransakcje(new Transakcja("04.06.1579", "Zakup atramentu", -12.99));
            k1.dodajTransakcje(new Transakcja("04.06.1579", "Lepsze, nowsze fajniejsze pióro do pisania", -19.99));
            k1.dodajTransakcje(new Transakcja("5.3.1580", "Wino", -5.5));
            k1.dodajTransakcje(new Transakcja("04.06.1579", "gorsze, ale tanśże pióro do pisania", -9.99));
            k1.dodajTransakcje(new Transakcja("5.3.1580", "Piwo", -2.5));
            k1.dodajTransakcje(new Transakcja("31.2.1580", "Ogladanie pysznego jedzenia przez czystą szybę, brudną twarzą - mycie okna", -1));
            k1.dodajTransakcje(new Transakcja("31.2.1580", "nocleg w kartonie na dostojnym dworze", -5));
            k1.dodajTransakcje(new Transakcja("1.3.1580", "Pranie fraku", -2));
            k1.dodajTransakcje(new Transakcja("1.3.1580", "Przelew na konto żebraka, z czytnikiem kart kredytowych", -0.01));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Wygrany zakład", 2));
            k1.dodajTransakcje(new Transakcja("5.3.1580", "Piwo", -2.5));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -4));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -5));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -2));
            k1.dodajTransakcje(new Transakcja("5.3.1580", "Piwo", -2.5));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -10));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -2));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -2));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Wygrany zakład", 2));
            k1.dodajTransakcje(new Transakcja("5.3.1580", "Piwo", -2.5));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -2));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -7));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -1));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -2));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -5));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -2));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -3));
            k1.dodajTransakcje(new Transakcja("2.3.1580", "Przegrany zakład", -2));
            k1.dodajTransakcje(new Transakcja("3.3.1580", "Darowizna w kościele, na rzecz pozbycia się nałogu hazardu", -2));
            k1.dodajTransakcje(new Transakcja("5.3.1580", "Piwo", -2.5));
            k1.dodajTransakcje(new Transakcja("5.3.1580", "Fajki", -15));
            k1.dodajTransakcje(new Transakcja("5.3.1586", "kredyt", -1500));
            k1.dodajTransakcje(new Transakcja("12.12.1586", "Zysk z pierwszej książki", 2500));
            k1.dodajTransakcje(new Transakcja("10.01.1587", "Praca u Wiśniowskiego", 3500));
            k1.dodajTransakcje(new Transakcja("10.01.1587", "Opicie pierwszej wypłaty", -35));
            k1.dodajTransakcje(new Transakcja("13.01.1587", "Rozwalona skrzynia biegów w Koniu", -700));
            k1.dodajTransakcje(new Transakcja("15.01.1587", "Dziurawa opona w prawym kopycie konia", -70));
            k1.dodajTransakcje(new Transakcja("15.01.1587", "Zimowe opony dla konia", -70));
            k1.dodajTransakcje(new Transakcja("15.02.1587", "Rabunek", -1000));
            k1.dodajTransakcje(new Transakcja("16.02.1587", "Rabunek", -1000));
            k1.dodajTransakcje(new Transakcja("17.02.1587", "Rabunek", -1000));
            k1.dodajTransakcje(new Transakcja("18.02.1587", "Denstyta", -1200));
            k1.dodajTransakcje(new Transakcja("18.02.1587", "Wyciągniecie noża z pleców", -120));
            k1.dodajTransakcje(new Transakcja("18.02.1587", "Zysk z drugiej książki", 2000));

            k1.informacjeOKoncie();

        }
    }
}
