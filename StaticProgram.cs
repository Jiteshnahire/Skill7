using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7.StaticVariable
{
    class StaticProgram
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Amol", 88.99);// 4 +4 + 8+ 5 =21
            Student s3 = new Student("John", 77.77, "USA"); // 4 +4 + 8 +3 =19

            // named argument
            Student s2 = new Student(percentage: 77.55, name: "Ajay");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.ReadLine();
        }
    }
}