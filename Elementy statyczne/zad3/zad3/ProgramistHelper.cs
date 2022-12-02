using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal static class ProgramistHelper
    {
        //Varaibles from zad1.
        private static string[] tabDate1;
        private static string[] tabDate2;
        private static DateTime d1;
        private static DateTime d2;
        private static int totalDays;
        private static DateTime tmpDate;
        private static int howManyBuisnesTimeDays;
        private static char[] chars = new char[] {'/', '.', ',', '-', ' '};

        //Variables from zad2.
        private static string fullSentence = "";
        private static char[] charArray;

        //Zad1.
        public static void HowManyDaysBetweenToDate(string date1="00.00.0000", string date2 = "00.00.0000")
        {
            try
            {
                tabDate1 = date1.Split(chars);
                tabDate2 = date2.Split(chars);
                int day1 = 0;
                int month1 = 0;
                int year1 = 0;
                int day2 = 0;
                int month2 = 0;
                int year2 = 0;
                howManyBuisnesTimeDays = 0;

                //add and Parse day to varaible
                if (tabDate1[0].Length <= 2 || tabDate2[0].Length <= 2)
                {
                    day1 = int.Parse(tabDate1[0]);
                    day2 = int.Parse(tabDate2[0]);
                }
                //add and Parse month to varaible
                if (tabDate1[1].Length <= 2 || tabDate2[1].Length <= 2)
                {
                    month1 = int.Parse(tabDate1[1]);
                    month2 = int.Parse(tabDate2[1]);
                }
                //add and Parse year to variable
                if (tabDate1[2].Length <= 4 || tabDate2[2].Length <= 4)
                {
                    year1 = int.Parse(tabDate1[2]);
                    year2 = int.Parse(tabDate2[2]);
                }
                //Convering int data from variables to DateTime.
                d1 = new DateTime(year1, month1, day1);
                d2 = new DateTime(year2, month2, day2);

                //Subtract one DateTime from second
                if (d1 > d2) { 
                    Console.Write($"Pomiedzy {d1.ToString("d")} a {d2.ToString("d")} jest w sumie {(d1 - d2).Days} dni. ");
                    totalDays = (d1 - d2).Days;
                    tmpDate = d2;
                }
                else { 
                    Console.Write($"Pomiedzy {d2.ToString("d")} a {d1.ToString("d")} jest w sumie {(d2 - d1).Days} dni. ");
                    totalDays = (d2 - d1).Days;
                    tmpDate = d1;
                }

                for(int i = 1; i <= totalDays; i++)
                {
                    if(tmpDate.DayOfWeek != DayOfWeek.Saturday && tmpDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        howManyBuisnesTimeDays++;
                    }
                    tmpDate = tmpDate.AddDays(1);
                }
                Console.WriteLine($"W tym {howManyBuisnesTimeDays} dni roboczych, oraz {totalDays - howManyBuisnesTimeDays} dni wolnych.");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Nie udało się przekonwertować podanych dat. Podany ciąg zawiera za dużo danych");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Któraś z podanych wartości nie jest liczba całkowitą");
            }
        }
        //Zad2.
        public static void ConcectTwoStringSentencesToOne(string first = "", string second = "")
        {
            fullSentence = first + " " + second;
            charArray = fullSentence.ToCharArray();
            bool yesIsUpper = false;

            //Check is there any UpperCase letters.
            foreach(char c in charArray)
            {
                if(Char.IsUpper(c))
                {
                    yesIsUpper = true;
                    break;
                }
            }
            //Make whole sentence to lowerCase
            if (yesIsUpper)
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    charArray[i] = Char.ToLower(charArray[i]);
                }
            }
            //Make every second letter -> UpperCase
            else if(yesIsUpper == false)
            {
                for(int i = 0; i < charArray.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        charArray[i] = Char.ToUpper(charArray[i]);
                    }
                }
            }
            //Show changed massage
            fullSentence = new string(charArray);
            Console.WriteLine(fullSentence);
        }

        public static void ChangeEveryWordWhoEndOnAEOToDupa()
        {
            //creating a path 

            string path = @"C:\Users\Lucjan\source\repos\Programowanie obiektowe\Elementy statyczne\zad3\DupaText.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            if (!File.Exists(path))
            {
                //Create a file
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(" murzynek bambo w afryce zamieszkał ");
                    sw.WriteLine(" czarną ma skórę ten nasz koleszka ");
                    sw.WriteLine(" Uczy się pilnie przez całe ranki. ");
                    sw.WriteLine(" Ze swej murzyńskiej pierwszej czytanki. ");
                    sw.WriteLine(" A gdy do domu ze szkoły wraca, ");
                    sw.WriteLine(" Psoci, figluje - to jego praca. ");
                    sw.WriteLine(" Aż mama krzyczy: Bambo, łobuzie! ");
                    sw.WriteLine(" A Bambo czarną nadyma buzię. ");
                    sw.WriteLine(" Mama powiada: Napij się mleka ");
                    sw.WriteLine(" A on na drzewo mamie ucieka. ");
                    sw.WriteLine(" Mama powiada :Chodź do kąpieli ");
                    sw.WriteLine(" A on się boi że się wybieli. ");
                    sw.WriteLine(" Lecz mama kocha swojego synka ");
                    sw.WriteLine(" Bo dobry chłopak z tego murzynka ");
                    sw.WriteLine(" Szkoda że Bambo czarny , wesoły ");
                    sw.WriteLine(" nie chodzi razem z nami do szkoły ");
                }
            }
            //Split text, and change everywhere where appears letter A O E on ends of words, to DUPA Word. 
            string text = File.ReadAllText(path);
            string[] splitText = text.Split(" ");

            for( int i = 0; i < splitText.Length; i++)
            {
                if (splitText[i].EndsWith("a") || splitText[i].EndsWith("e") || splitText[i].EndsWith("o"))
                {
                    splitText[i] = "dupa";
                }
            }
            text = "";
            for( int i = 0; i < splitText.Length; i++)
            {
                text += splitText[i] + " ";
            }
            File.WriteAllText(path, text);

            //open File
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void ChangeEveryDupaWordInTextInRandomWord()
        {
            string path = @"C:\Users\Lucjan\source\repos\Programowanie obiektowe\Elementy statyczne\zad3\DupaText.txt";

            string text = File.ReadAllText(path);
            string[] splitText = text.Split(" ");

            for (int i = 0; i < splitText.Length; i++)
            {
                if (splitText[i] == "dupa")
                {
                    splitText[i] = randomWord();
                }
            }
            text = "";
            for (int i = 0; i < splitText.Length; i++)
            {
                text += splitText[i] + " ";
            }
            File.WriteAllText(path, text);

            //open File
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            string randomWord()
            {
                Random random = new Random();
                int x = random.Next(0,10);
                switch (x)
                {
                    case 0: return "kij";
                    case 1: return "browar";                    
                    case 2: return "banan";
                    case 3: return "melony";                    
                    case 4: return "kokos";
                    case 5: return "mielony";                    
                    case 6: return "skacze";
                    case 7: return "palma";
                    case 8: return "szlugi";
                    case 9: return "flaszka";
                    default: return "bambo";
                }
            }
        }


    }
}
