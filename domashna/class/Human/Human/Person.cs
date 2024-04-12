using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal class Person
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string pol;

        public void writeforhuman() {
            Console.WriteLine($"{Name} е  на {age} години и полът му е  {pol}.");

        }
    }
}
