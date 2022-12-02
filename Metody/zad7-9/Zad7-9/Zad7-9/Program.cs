namespace Zad7_9
{
    internal class Program
    {
        public delegate void Show(List<User> Listusers);
        public delegate void UsersWithLetter(string letter);
        public delegate void Names();

        static void Main(string[] args)
        {
            Program p1 = new Program();

            List<User> ListOfUsers = new List<User>();

            ListOfUsers.Add(new User("Jan", "M", 15));
            ListOfUsers.Add(new User("Jan", "M", 15));
            ListOfUsers.Add(new User("Adam", "M", 12));
            ListOfUsers.Add(new User("Adam", "M", 12));
            ListOfUsers.Add(new User("Adam", "M", 12));
            ListOfUsers.Add(new User("Bożena", "F", 22));
            ListOfUsers.Add(new User("Helga", "F", 44));
            ListOfUsers.Add(new User("Patrycja", "F", 33));
            ListOfUsers.Add(new User("Janusz", "M", 23));
            ListOfUsers.Add(new User("Robert", "M", 25));
            ListOfUsers.Add(new User("Wojtek", "M", 29));
            ListOfUsers.Add(new User("Kamil", "M", 15));
            ListOfUsers.Add(new User("Kamila", "F", 28));

            User u = new User();

            UsersWithLetter uswl = delegate (string letter)
            {
                int x = 0;
                for (int i = 0; i < ListOfUsers.Count; i++)
                {
                    if (ListOfUsers[i].Name.StartsWith(letter))
                    {
                        Console.WriteLine(ListOfUsers[i].Name);
                        x++;
                    }
                }
                if (x == 0)
                {
                    Console.WriteLine("Nie ma żadej osoby o tym imieniu.");
                }
            };
            Names HowManyFemAndMan = delegate ()
            {
                int F = 0;
                int M = 0;
                for (int i = 0; i < ListOfUsers.Count; i++)
                {
                    if (ListOfUsers[i].Sex == "F")
                    {
                        F++;
                    }
                    else if (ListOfUsers[i].Sex == "M")
                    {
                        M++;
                    }
                }
                Console.WriteLine("Kobiety :" + F);
                Console.WriteLine("Mężczyźni : " + M);
            };

            Names Add10Years = delegate ()
            {
                for (int i = 0; i < ListOfUsers.Count; i++)
                {
                    ListOfUsers[i].Age += 10;
                }
            };
            Names NamesWitchNoRepeat = delegate ()
            {
                bool exist = false;
                for (int i = 0; i < ListOfUsers.Count; i++)
                {
                    int how = 0;
                    for (int j = 0; j < ListOfUsers.Count; j++)
                    {
                        if (ListOfUsers[i].Name == ListOfUsers[j].Name)
                        {
 
                            how++;
                        }
                        
                    }
                    if(how < 2)
                    {
                        Console.WriteLine(ListOfUsers[i].Name);
                    }
                }
            };

            Names Sort = delegate ()
            {
                ListOfUsers.Sort();
                for (int i = 0; i < ListOfUsers.Count; i++)
                {
                    Console.WriteLine(ListOfUsers[i].Name);
                }
            };

            uswl("J");
            Console.WriteLine();
            u.Give5MoreUssers(ListOfUsers,"R" );
            NamesWitchNoRepeat();
            HowManyFemAndMan();
            Console.WriteLine();

        }
    }
    public class User
    {
        private string name;
        private string sex;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }

        public User(string name, string sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
        }
        public User()
        {
        }

        Program p1 = new Program();
        public void Give5MoreUssers(List<User> d1, string letter )
        {
            d1.Add(new User("Lucjan", "M", 30));
            d1.Add(new User("Emilia", "F", 28));
            d1.Add(new User("Ula", "F", 44));
            d1.Add(new User("Dorota", "F", 31));
            d1.Add(new User("Aneta", "F", 30));

            int x = 0;
            for (int i = 0; i < d1.Count; i++)
            {
                if (d1[i].Name.StartsWith(letter))
                {
                    Console.WriteLine(d1[i].Name);
                    x++;
                }
            }
            if (x == 0)
            {
                Console.WriteLine("Nie ma żadej osoby o tym imieniu.");
            }
        }
    }
}