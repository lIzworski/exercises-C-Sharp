using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Osoba
    {
        private string _name = "";
        private string _surname = "";
        private int _age = 0;
        private string _sex = "";

        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public int Age { get { return _age; } set { if (_age > 0 && _age < 101) { _age = value; } } }
        public string Sex { get { return _sex; } set { if (_sex == "kobieta" || _sex == "mężczyzna" || _sex == "inna") { _sex = value; } } }

    }
}
