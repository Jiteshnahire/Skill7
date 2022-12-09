using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7.OOPs
{
    class Student
    {
        private int roll, m1, m2, m3;
        private string name;
        private float total, percentage;

        public Student(int roll, string name, int m1, int m2, int m3)
        {
            this.roll = roll;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.name = name;
        }
        public void ObtainedMarks()
        {
            total = (m1 + m2 + m3);
            percentage = (total) / 3;
        }
        public override string ToString()
        {
            return $"Student id  {roll}, Student name {name}, Total marks{total} & Percentage of Student {percentage}";
        }
        static void Main(string[] args)
        {
            Student s = new Student(121, "Jitesh", 50, 60, 70);
            s.ObtainedMarks();
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
    