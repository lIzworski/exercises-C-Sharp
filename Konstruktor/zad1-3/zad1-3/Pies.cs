using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_3
{
    internal class Pies
    {
        private string _name = "";
        private int _age = 0;
        private string _rasa = "";
        private static int _howManyDogs = 0;

        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Rasa { get { return _rasa; } set { _rasa = value; } }
        

        public Pies(string name, int age, string rasa = "Mongrel")
        {
            Name = name;
            Age = age;
            Rasa = rasa;
            _howManyDogs++;
        }
        public static void HowManyDogs()
        {
            Console.WriteLine($"Ilość psów : {_howManyDogs}");
        }
    }
}
