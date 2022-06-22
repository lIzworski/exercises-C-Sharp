namespace II._9_kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs k1 = new Kurs("Zbieranie kijów", 100, "Pan z Kijowa");
            //Dodanie Grupy[0];
            k1.dodajGrupe();
            //Dodanie Grupy[1];
            k1.dodajGrupe();
            //Dodaj osobe do Grupy[0];
            Kurs.Grupy[0].dodajOsobe(new Osoba("Jan", "Janowski", 23));
            Kurs.Grupy[0].dodajOsobe(new Osoba("Krystian", "Krystiański", 24));
            Kurs.Grupy[0].dodajOsobe(new Osoba("Jan", "Janczak", 40));
            Kurs.Grupy[0].dodajOsobe(new Osoba("Kijowsław", "Kijowski", 83));
            //Dodaj osobe do Grupy[1];
            Kurs.Grupy[1].dodajOsobe(new Osoba("Mirosław", "Zelent", 42));
            Kurs.Grupy[1].dodajOsobe(new Osoba("Czesław", "Konieczyna", 55));
            Kurs.Grupy[1].dodajOsobe(new Osoba("Wiesław", "Brzękiewicz", 32));
            k1.wyswietlGrupe(1, Kurs.Grupy[0]);






        }
    }
}
