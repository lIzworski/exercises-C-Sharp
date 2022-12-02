using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Invoice
    {
        private static int _documentNumber = 0;
        private DateOnly _documentDate;
        private string _customer;
        private double _DocumentValue = 0;
        private string _issuer;
        private List <Item> ?_itemList = new List<Item>();

        public static int DocumentNumber { get => _documentNumber; set => _documentNumber = value; }
        public DateOnly DocumentDate { get => _documentDate; set => _documentDate = value; }
        public string Customer { get => _customer.ToUpper(); set => _customer = value; }
        public double DocumentValue { get => _DocumentValue; set => _DocumentValue = value; }
        public string Issuer { get => _issuer.ToUpper(); set => _issuer = value; }
        internal List<Item> ItemList { get => _itemList; set => _itemList = value; }

        public static Invoice operator +(Invoice Left, Invoice Right)
        {
            Invoice tmpInv = Left;
            tmpInv._itemList.AddRange(Right._itemList);
            tmpInv.DocumentValue = 0;
            double tmpDCValue = 0;
            foreach (var item in tmpInv._itemList)
            {
                tmpInv.DocumentValue += item.Brutto;
            }
            return tmpInv;
        }
        public static Invoice operator -(Invoice Left, Invoice Right)
        {
            bool exist = false;
            Invoice tmp = new Invoice();
            tmp.Issuer = Left.Issuer;
            tmp.DocumentDate = Left.DocumentDate;
            tmp.Customer = Left.Customer;
            for(int i = 0; i < Left.ItemList.Count; i++)
            {
                for(int j = 0; j < Right.ItemList.Count; j++)
                {
                    if(Left.ItemList[i].Name == Right.ItemList[j].Name)
                    {
                       exist = true;
                    }
                    else if(exist == false)
                    {
                        tmp.ItemList.Add(Left.ItemList[i]);
                        exist = false;
                    }
                }
            }
            return tmp;
        }
        public static bool operator >(Invoice Left, Invoice Right)
        {
            return Left.DocumentValue > Right.DocumentValue;
        }        
        public static bool operator <(Invoice Left, Invoice Right)
        {
            return Left.DocumentValue < Right.DocumentValue;
        }
        public static bool operator >=(Invoice Left, Invoice Right)
        {
            return Left.DocumentValue >= Right.DocumentValue;
        }
        public static bool operator <=(Invoice Left, Invoice Right)
        {
            return Left.DocumentValue <= Right.DocumentValue;
        } 
        public static bool operator ==(Invoice Left, Invoice Right)
        {
            return Left.Equals(Right);
        }        
        public static bool operator !=(Invoice Left, Invoice Right)
        {
            return !Left.Equals(Right);
        }
        public static Invoice operator &(Invoice Left, Invoice Right)
        {
            Invoice result = new Invoice();
            result = Left;
            return result;
        }

        public Invoice( DateOnly documentDate, string customer,  string issuer)
        {
            DocumentNumber++;
            DocumentDate = documentDate;
            Customer = customer;
            Issuer = issuer;
        }

        public Invoice()
        {
        }

        public void AddNewItem(Item item)
        {
            bool exist = false;
            for(int i = 0; i < ItemList.Count; i++)
            {
                if(item.Name == ItemList[i].Name)
                {
                    exist = true;
                    ItemList[i].Brutto += item.Brutto;
                    ItemList[i].Quatntity++;
                }
            }
            if(exist == false)
            {
                ItemList.Add(item);
                DocumentValue += item.Brutto; 
            }
        }

        public new void ToString()
        {
            Console.WriteLine($"Nr. Faktury : {++DocumentNumber}, Data wyst.Faktury : {DocumentDate}, Odbiorca : {Customer}, Wartość dokumentu : {DocumentValue}zł, Wystawił : {Issuer}");
            for(int i = 0; i < ItemList.Count; i++)
            {
                if (ItemList[0] == null){ }
                else{ItemList[i].ToString();}
            }
            Console.WriteLine();

        }
    }
}
