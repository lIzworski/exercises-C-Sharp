using System.Security.Cryptography.X509Certificates;

namespace zad1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Object b1;
            //a.
            int SumOfTwoNumbers(int x, int y)
           {
                return x + y;
           }
            Console.WriteLine(SumOfTwoNumbers(5,190));
            //b.
            string JoinTwoString(string a, string b)
            {
                return a + b;
            }
            Console.WriteLine(JoinTwoString("Gdy Niemożliwe staje się możliwym,","A chałas przysłania cisza."));
            //c.
            Object giveBackAInstanceOfObject()
            {
               return b1 = new object();
            }
            //d.
            void IamNotReturningAnything()
            {
                Console.WriteLine("ja nic nie zwracam");
            }

        }
    }
}