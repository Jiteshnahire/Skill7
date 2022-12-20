using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7
{
    class MaxTwoArray
    {
        static void maxelement(int no, int[][] arr)
        {
            int i = 0;
            int max = 0;
            int[] result = new int[no];
            while (i < no)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                }
                result[i] = max;
                max = 0;
                i++;
            }
            printArray(result);
        }
        private static void printArray(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
        public static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
        new int[] {1, 2, 3},
        new int[] {4, 5, 6},
        new int[] {7, 8, 9},
        new int[] {21, 11, 14}
            };
            maxelement(4, arr);
            Console.WriteLine();
        }
    }
}