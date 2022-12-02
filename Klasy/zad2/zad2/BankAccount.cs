using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static zad2.BankAccount;

namespace zad2
{
    internal class BankAccount
    {
        private int accountNumber = 0;
        private double moneyOnAccount = 0;
        SavingsBankAccount sba;

        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public double MoneyOnAccount { get { return moneyOnAccount; } set { moneyOnAccount = value; } }


        public BankAccount(double moneyOnAccount, double moneyOnSavingsAccount)
        {
            sba = new SavingsBankAccount();
            sba.MoneyOnSavingsAccount = moneyOnSavingsAccount;
            Random random = new Random();
            AccountNumber = random.Next(1000000, 9999999);
            MoneyOnAccount = moneyOnAccount;
        }

        public void SplitPayment(double paymentOnBankAccount, double tax)
        {
            MoneyOnAccount += paymentOnBankAccount;
        }

        public void showSavingAccountInformations()
        {
            Console.WriteLine($"Numer konta oszczednosciowego : {sba.SavingsAccountNumber}, Stan Konta : {sba.MoneyOnSavingsAccount}\n\n");
        }
        internal class SavingsBankAccount 
        {
            private int savingsAccountNumber = 0;
            private double moneyOnSavingsAccount = 0;

            public int SavingsAccountNumber { get { return savingsAccountNumber; } set { savingsAccountNumber = value; } }
            public double MoneyOnSavingsAccount { get { return moneyOnSavingsAccount; } set { moneyOnSavingsAccount = value; } }

            public SavingsBankAccount()
            {
                Random random = new Random();
                SavingsAccountNumber = random.Next(1000000, 9999999);
            }

        }
    }
}
