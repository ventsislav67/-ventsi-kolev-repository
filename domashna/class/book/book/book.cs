using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    internal class book
    {
       
        public string author;
        public string title;
        public int age ;
        public void writeall() {
            Console.WriteLine($"Книгата с заглавие {title} и автор {author}  е издадена през {age} ");

        }
    }
}
