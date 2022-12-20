using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7
{
    class PushZeroLast
    {
        static void pushZerosToEnd(int[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)
                    arr[count++] = arr[i];

            while (count < n)
                arr[count++] = 0;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
            int n = arr.Length;
            pushZerosToEnd(arr, n);
            Console.WriteLine("pushing all zeros: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}