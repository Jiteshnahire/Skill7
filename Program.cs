using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7.OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            /*  b.Id = 123;
              b.name = "C sharp";
              b.author = "Mark";
              b.price = 250;*/
            Book b1 = new Book { Id = 123, Name = "Harry", Author = "Vinaya", Price = 100 };


            Console.WriteLine();
        }
    }
}

