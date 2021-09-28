using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxConsecutiveSum_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 2, 3, 5, 1, 6 };
            int k = 2;
            int n = arrayMaxConsecutiveSum(inputArray,k);
            Console.WriteLine(n);

        }

        static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            int max = 0;

            for (int i = 0; i < inputArray.Length - (k - 1); i++)
            {
                int curr = 0;

                for (int j = i; j < (i + k); j++)
                {
                    curr += inputArray[j];
                }

                if (curr > max) max = curr;
            }

            return max;
        }
    }
}
