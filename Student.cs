using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7.StaticVariable
{
    class Student
    {

        private int rollno;
        private string name, country;
        private double percentage;
        private static int count;
        public Student(string name, double percentage, string country = "India")
        {
            count++;
            rollno = count;
            this.name = name;
            this.percentage = percentage;
            this.country = country;
        }

        public override string ToString()
        {
            return $"{rollno} -> {name} -> {percentage}->{country}";
        }
    }

}