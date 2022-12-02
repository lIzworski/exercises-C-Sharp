using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Pracownik
    {
        private string name = "";
        private string surname = "";
        private string position = "";
        private double salary;
        private int numberOfVacationsDays;
        private int numberOfUsedVacationDays;
        private int numberOfVacationDaysRemaining;
        BankAccount bankAccount;
        Invoice invoice;


        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Position { get { return position; } set { position = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public int NumberOfVacationsDays { get { return numberOfVacationsDays; } set { numberOfVacationsDays = value; } }   
        public int NumberOfUsedVacationDays { get { return numberOfUsedVacationDays; } set { numberOfUsedVacationDays = value; } }
        public int NumberOfVacationDaysRemaining { get { return numberOfVacationDaysRemaining; } set { numberOfVacationDaysRemaining = value; } }

        public Pracownik(string Name, string Surname, string Position, double Salary, int NumberOfVacationsDays, int NumberOfUsedVacationDays, double moneyOnAccount, double moneyOnSavingAccount )
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Position = Position;
            this.Salary = Salary;
            this.NumberOfVacationsDays = NumberOfVacationsDays;
            this.NumberOfUsedVacationDays = NumberOfUsedVacationDays;
            bankAccount = new BankAccount(moneyOnAccount, moneyOnSavingAccount);
        }

        public void ShowPersonInformations()
        {
            Console.WriteLine($"Imie: {Name}, nazwisko: {Surname}, stanowisko: {Position}, pensja: {Salary}, ilość pozostałych dni urlopu {numberOfRemainedVacationDays()}");
            Console.WriteLine($"Numer konta: {bankAccount.AccountNumber}, Stan konta : {bankAccount.MoneyOnAccount:##.##}zł");
            bankAccount.showSavingAccountInformations();
        }

        public void takeFewDaysOff(int howManyDays)
        {
            if(howManyDays < numberOfRemainedVacationDays()){
                Console.WriteLine("Udało ci się uzyskać urlop\n");
                NumberOfVacationDaysRemaining -= howManyDays;
            }
            else
            {
                Console.WriteLine($"Nie masz wystarczającej ilości dni wolnych, by wziąść tyle dni urlopu. masz do dyspozycji {NumberOfVacationDaysRemaining} dni wolnych.\n");
            }
        }

        public void PaySalary(int InvoiceNumber, DateTime DateOfIssueofInvoice, string NameOfService, double tax )
        {     
            string SellerName = "Mafia";
            invoice = new Invoice(bankAccount,InvoiceNumber, DateOfIssueofInvoice, SellerName, Name+" "+Surname, NameOfService, Salary, tax);
            invoice.settleTheinvoice(salary, tax);
            
        }

        private int numberOfRemainedVacationDays()
        {
            return NumberOfVacationDaysRemaining = NumberOfVacationsDays - NumberOfUsedVacationDays;
        }
    }
}
