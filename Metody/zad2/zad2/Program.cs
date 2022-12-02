namespace zad2
{
    internal class Program
    {
        delegate void FindUserInList(string letter);
        static void Main(string[] args)
        {
            //2.
            void metoda(object x, int y = 0)
            {
                Console.WriteLine(x +" "+ y);
            }
            metoda(1);
            metoda(2, 10);

            //3.

            //4.
            Console.WriteLine("\nZad4\n");
            int[] tab = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            void ModifyArray()
            {
                for(int i = 0; i < tab.Length; i++)
                {
                    tab[i] = i + 2 ;
                }
            }
            ModifyArray();

            foreach(int i in tab)
            {
                Console.Write(i);
            }
            //5.
            //6.
            List<User> list = new List<User>();
            list.Add(new User("Jacek", 22, "M"));
            list.Add(new User("Placek", 44, "M"));
            list.Add(new User("Wacek", 32, "F"));
            list.Add(new User("Płotka", 54, "M"));
            list.Add(new User("Kasztanka", 25, "F"));
            list.Add(new User("Rydz", 29, "M"));
            list.Add(new User("Rambo123", 92, "M"));
            list.Add(new User("Bambo", 98, "M"));
            list.Add(new User("kat", 62, "M"));
            list.Add(new User("JBZDY", 57, "F"));
            //7.
            Console.WriteLine();
            Console.WriteLine();
            FindUserInList fu = delegate (string letter)
            {
                foreach (User u in list)
                {
                    if (u.Name.StartsWith(letter))
                    {
                        Console.WriteLine(u.Name);
                    }
                }
            };
            fu("R");
           
            
        }
    }
}