using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal static class StaticClass
    {
        static DateTime date1;
        static bool failed = false;
        static int failedInt = 0;
        static int passedInt = 0;
        static char[] separators = new char[] { ' ', '.', ',', '/' };

        public static void TimeConventedToPL(string ddMMyyyy)
        {
            try
            {
                failed = false;
                string word = ddMMyyyy;
                string[] splitedString = word.Split(separators);

                if (splitedString[0].Length > 2) { failed = true; failedInt++; splitedString[0] = "0"; }
                else if (splitedString[1].Length > 2) { failed = true; failedInt++; splitedString[1] = "0"; }
                else if (splitedString[2].Length > 4) { failed = true; failedInt++; splitedString[2] = "0"; }

                if(failed == false)
                {
                    date1 = new DateTime();
                    date1.AddDays(int.Parse(splitedString[0]));
                    date1.AddMonths(int.Parse(splitedString[1]));
                    date1.AddYears(int.Parse(splitedString[2]));
                }
                if(failed == false)
                {
                    passedInt++;
                }
            }
            catch (IndexOutOfRangeException e)
            {                
            }
        }
        public static void howManyFailsAndPassed()
        {
            Console.WriteLine($"fails : {failedInt}");
            Console.WriteLine($"passed : {passedInt}");
        }
    }
}
