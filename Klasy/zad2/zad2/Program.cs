namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Piotrek", "Poziomek", "Kmiot", 1250.50, 24, 10, 1000, 250);
            Pracownik p2 = new Pracownik("Wincenty", "Jaraskręty", "Pomiot", 250.50, 24, 24, 9.50, 0.11);
            Pracownik p3 = new Pracownik("Bożydar", "Garbaty", "Miotłowy", 1150.50, 24, 0, 2000, 50);
            Pracownik p4 = new Pracownik("Krzysztof", "Jerzyna ze Szczecina", "Szef wszystkich szefów", 20000, 365, 120, 9066600, 25000000);
            Pracownik p5 = new Pracownik("Mieszko", "z Bogdańca", "Rycerz nadworny", 2250.50, 24, 20, 100, 250);
            Pracownik p6 = new Pracownik("Dracula", "z Bystrzycy", "Vampir", 7220.50, 29, 11, 1000000, 25000);
            Pracownik p7 = new Pracownik("Wojtek", "Poziomek", "Kmiot", 2220.50, 24, 10, 1000, 250);

            List<Pracownik> listOfWorkers = new List<Pracownik>();

            listOfWorkers.Add(p1);
            listOfWorkers.Add(p2);
            listOfWorkers.Add(p3);
            listOfWorkers.Add(p4);
            listOfWorkers.Add(p5);
            listOfWorkers.Add(p6);
            listOfWorkers.Add(p7);

/*            foreach(Pracownik p in listOfWorkers)
            {
                p.ShowPersonInformations();
            }*/

            p1.PaySalary(1, DateTime.Now, "Sprzątanie", 18);
            p1.ShowPersonInformations();

            Project pj1 = new Project("Cicha noc");
            pj1.AddAEmployeeToProject(p1);
            pj1.AddAEmployeeToProject(p2);

            pj1.AddNewTask(1,"Zabij");
            pj1.AddNewTask(2,"Zawieź");
            pj1.AddNewTask(3,"Zakop");

            pj1.AddFreeEmployeeToTask(1, p1);
            pj1.AddFreeEmployeeToTask(2, p2);

            pj1.showWhoWorkWere();
        }
    }
}