using System;

namespace Zad_II._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zamowienie order1 = new Zamowienie("19.05.2022r", "Pan Krzysztof Jarzyna ze Szczecina");

            order1.dodajPozycje(new Sprzedaz("Karma dla lwa", 1, 20000));
            order1.dodajPozycje(new Sprzedaz("Książka pt:\"Kicci Kicci, Taś, Taś - Jak nie mówić do lwa\".", 1, 24.9));
            order1.dodajPozycje(new Sprzedaz("Różyczki dla dziewczyny", 1, 500));
            order1.dodajPozycje(new Sprzedaz("Guziec - taka świnia z afryki", 1, 2000));
            order1.dodajPozycje(new Sprzedaz("Dolores", 1, 0));
            order1.dodajPozycje(new Sprzedaz("Mario Puzo - Ojciec Chrzestny", 1, 49.99));
            order1.dodajPozycje(new Sprzedaz("Oryginalna plakietka dla bramkarza", 1, 12.99));
            order1.dodajPozycje(new Sprzedaz("Choinka o zapachu kokosowym do malucha", 3, 5.99));
            order1.dodajPozycje(new Sprzedaz("Karton fajerwerek", 1, (40000 * 4.31)));
            order1.wydrykujCalaListeZakupow();

        }
    }
}
