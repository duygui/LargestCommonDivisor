using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = getGcd(new int[] { 12, 4, 8 }, 3);
        }
        
           public static int getGcd(int[] arr, int num)
        {
            int gcd = 1;
            int arrMinVal = arr.Min();

            for (int i = 2; i <= arrMinVal; i++)
            {
                var isOk = true;
                for (int j = 0; j < num; j++)
                {
                    if (arr[j] % i != 0)
                        isOk = false;
                }
                if (isOk) gcd = i;
            }
            return gcd;
        }
