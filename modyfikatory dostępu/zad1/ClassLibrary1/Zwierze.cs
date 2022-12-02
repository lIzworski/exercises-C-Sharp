using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Zwierze
    {
        private int _age;

        public int Age { set { _age = value; } }
        private void ZwierzeMetoda()
        {

        }
        internal void MakeSound()
        {
            Console.WriteLine("MakeSound");
        }
        public void PsiaMetoda() 
        {

        }
    }
}
