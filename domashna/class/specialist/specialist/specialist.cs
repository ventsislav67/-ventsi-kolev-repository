using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialist
{
    internal class specialist
    {
        public string name;
        public int salary { get; set; }
        public string otdel { get; set; }
        public void writeforspec() {
            Console.WriteLine($"Специалистът {name}, със заплата {salary} от отдел {otdel}.");
        }
    }
}
