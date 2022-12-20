using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7.RefKeyword
{
    class Swap
    {
        static void Swa(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;   // b-> a
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before call the method a={a} , b={b}");
            Swa(ref a, ref b); // referecne  / address
            Console.WriteLine($"after call the method a={a} , b={b}");
            Console.ReadLine();
        }
    }
}

