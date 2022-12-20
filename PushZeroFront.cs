using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7
{
    class PushZeroFront
    {
        public static void Main()
        {
            int[] array = { 2, 10, 0, 5, 3, 0, 4, 1 };
            MoveZeroesFront(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void MoveZeroesFront(int[] array)
        {
            int count = array.Length - 1;

            for (int k = array.Length - 1; k >= 0; k--)
            {
                if (array[k] != 0)
                {
                    int t = array[count];
                    array[count] = array[k];
                    array[k] = t;
                    count--;
                }
            }
        }
    }
}
