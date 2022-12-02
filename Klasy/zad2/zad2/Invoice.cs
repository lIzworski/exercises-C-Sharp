using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Invoice
    {
        private int invoiceNumber;
        private DateTime dateOfIssueofInvoice;
        private string sellerName = "";
        private string buyerName = "";
        private string nameOfService = "";
        private double price;
        private double tax;
        BankAccount bankAccount;

        public int InvoiceNumber { get { return invoiceNumber; } set { invoiceNumber = value; } }
        public DateTime DateOfIssueofInvoice { get { return dateOfIssueofInvoice; } set { dateOfIssueofInvoice = value; } }
        public string SellerName { get { return sellerName; } set { sellerName = value; } }
        public string BuyerName { get { return buyerName; } set { buyerName = value; } }
        public string NameOfService { get { return nameOfService; } set { nameOfService = value; } }
        public double Tax { get { return tax; } set { tax = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Invoice(BankAccount bankAccountt, int invoiceNumber, DateTime dateOfIssueofInvoice, string sellerName, string buyerName, string nameOfService, double price, double tax)
        {
            InvoiceNumber = invoiceNumber;
            DateOfIssueofInvoice = dateOfIssueofInvoice;
            SellerName = sellerName;
            BuyerName = buyerName;
            NameOfService = nameOfService;
            Price = price;
            Tax = tax;
            bankAccount = bankAccountt;
        }

        public void settleTheinvoice(double Price, double taxInPercentage )
        {
            double netto = Price - (taxInPercentage / 100);
            double tax = (taxInPercentage / 100) * netto ;
            bankAccount.SplitPayment(netto,tax);
        }
    }
}
