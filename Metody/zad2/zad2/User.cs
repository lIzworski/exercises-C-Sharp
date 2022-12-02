using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class User
    {
        public delegate void FindUserInList(string letter);
        private string name = "";
        private int age;
        private string sex;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Sex { get { return sex; } set { sex = value; } }
        
        public User(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public static void  GetList(List<User> users, FindUserInList dele)
        {

        }
    }
}
