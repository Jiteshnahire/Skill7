﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7.String
{
    class Anagram
    {
        static void Main(string[] args)
        {
            string str1 = "silent";
            string str2 = "listen";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("strings are Anagrams");
            }
            else
            {
                Console.WriteLine("not Anagrams");
            }
        }
    }
}
