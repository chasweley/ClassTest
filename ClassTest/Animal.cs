using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public void MakeNoise()
        {
            Console.WriteLine("Woaw " + Name);
        }
    }
}
