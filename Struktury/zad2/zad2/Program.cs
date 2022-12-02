using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static zad2.Program;

namespace zad2
{
    internal class Program
    {
        public struct InvoiceStruck
        {
            public string Name;
            public int PositionNumber;
            public Value Value;

            public InvoiceStruck(string name, int positionNumber, Value value)
            {
                Name = name;
                PositionNumber = positionNumber;
                Value = value;
            }

        }
        public struct Value
        {
            public double Netto;
            public double Price;
            public int Vat;

            public Value(double netto, double price, int vat)
            {
                Netto = netto;
                Price = price;
                Vat = vat;
            }
        }
        public class Invoice
        {

            public List<InvoiceStruck> invoices = new List<InvoiceStruck>();

            public void AddNewInvoice(InvoiceStruck invoiceStr)
            {
               if(invoices.Count == 0)
               {
                    invoices.Add(invoiceStr);
               }
               else
               {
                    bool NamesIsSames = false;
                    for(int i = 0; i < invoices.Count; i++)
                    {
                        if (invoiceStr.Name == invoices[i].Name)
                        {
                            NamesIsSames = true;
                            double tmpPrice = invoices[i].Value.Price;
                            double tmpNetto = invoices[i].Value.Netto;
                            invoices.RemoveAt(i);
                            invoiceStr.Value.Netto += tmpNetto;
                            invoiceStr.Value.Price += tmpPrice;
                            invoices.Add(invoiceStr);
                        }
                    }
                    if(NamesIsSames == false)
                    {
                        invoices.Add(invoiceStr);
                    }
               }
            }    
            public void DeleteInvoce(int PositionNumber)
            {
                invoices.RemoveAt(PositionNumber);
            }

            public void ToString()
            {
                Random rand = new Random();
                int documentNumber = 0;
                string[] persons = new string[] {"Janek","Wojtek","Krzysiek","Michał", "Marcin", "Wieśiek", "Henryk", "Mietek", "Jurek", "Zbyszek", "Jarek", "Grzesiek","Lucek"};
                foreach (var item in invoices)
                {
                    int witchPerson1 = rand.Next(1, 12);
                    int witchPerson = rand.Next(1, 12);
                    int day = rand.Next(1, 28);
                    int month = rand.Next(1, 13);
                    int year = rand.Next(1899, 2099);
                    DateTime date = new DateTime(year, month, day);

                    Console.WriteLine($"Numer dokumenty: {documentNumber} Data wystawienia: {date}, odbiorca: {persons[witchPerson].ToUpper()} wydawca: {persons[witchPerson1].ToUpper()}");
                    Console.WriteLine($"Nazwa: {item.Name.ToUpper()}, Nr.Poz. {item.PositionNumber}, Netto: {item.Value.Netto}zł. Vat: {item.Value.Vat}%  Cena Brutto: {item.Value.Price}zł.\n");
                    documentNumber++;
                }
            }

        }
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.AddNewInvoice(new InvoiceStruck("Kartofle", 0, new Value(100, 118, 18)));
            invoice.AddNewInvoice(new InvoiceStruck("Buraki", 1, new Value(200, 240, 20)));
            invoice.AddNewInvoice(new InvoiceStruck("Kluski", 2, new Value(420, 504, 20)));
            invoice.AddNewInvoice(new InvoiceStruck("Poziomki", 3, new Value(200, 236, 18)));
            invoice.AddNewInvoice(new InvoiceStruck("Truskawki", 4, new Value(400, 472, 18)));
            invoice.AddNewInvoice(new InvoiceStruck("Lizaki", 5, new Value(300, 333, 11)));
            invoice.AddNewInvoice(new InvoiceStruck("Lizaki", 5, new Value(300, 333, 11)));
            invoice.AddNewInvoice(new InvoiceStruck("Pantofle", 6, new Value(100, 112, 12)));
            invoice.AddNewInvoice(new InvoiceStruck("Energetyki", 7, new Value(200, 220, 10)));
            invoice.AddNewInvoice(new InvoiceStruck("Chleby", 8, new Value(200, 260, 30)));
            invoice.AddNewInvoice(new InvoiceStruck("Bułki", 9, new Value(250, 375, 50)));

            invoice.ToString();
            
        }
    }
}