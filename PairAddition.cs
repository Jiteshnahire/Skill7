using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7
{
    class PairAddition
    {
        public static void findPair(int[] no, int target)
        {
            for (int i = 0; i < no.Length - 1; i++)
            {
                for (int j = i + 1; j < no.Length; j++)
                {
                    if (no[i] + no[j] == target)
                    {
                        Console.WriteLine(target);
                        return;
                    }
                }
            }
            Console.WriteLine("Pair not found");
        }
        public static void Main(string[] args)
        {
            int[] no = { 8, 7, 2, 5, 3, 1 };
            int target = 10;

            findPair(no, target);
        }
    }
}

