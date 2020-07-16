using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int count = 3;
            //int ans = add_sum_helperF(arr,count);
            //int ans = add_sum_helperB(arr, count);
            //int ans = add_sum_helperF_even(arr, count);
            //int ans = add_sum_helperB_even(arr, count);
            //int ans = add_sum_helperF_odd(arr, count);
            int ans = add_sum_helperB_odd(arr, count);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        static int add_sumFB(int[] arr, int upperBound, int lowerBound)
        {
            if (upperBound < lowerBound)
            {
                return 0;
            }
            return arr[upperBound] + add_sumFB(arr, upperBound - 1, lowerBound);
        }
        static int add_sumEven(int[] arr, int upperBound, int lowerBound)
        {
            if (upperBound < lowerBound)
            {
                return 0;
            }
            return arr[upperBound] + add_sumEven(arr, upperBound - 2, lowerBound);
        }
        static int add_sum_helperF(int[] arr, int count)
        {
            int upperBound = count - 1;
            int lowerBound = 0;
            return add_sumFB(arr, upperBound, lowerBound);
        }
        static int add_sum_helperB(int[] arr, int count)
        {
            int upperBound = arr.Length - 1;
            int lowerBound = upperBound - count + 1;
            return add_sumFB(arr, upperBound, lowerBound);
        }
        static int add_sum_helperF_even(int[] arr, int count)
        {
            int upperBound = count * 2 - 2;
            int lowerBound = 0;
            return add_sumEven(arr, upperBound, lowerBound);
        }
        static int add_sum_helperB_even(int[] arr, int count)
        {
            int lastIndx = arr.Length - 1;
            int upperBound = lastIndx%2==0? lastIndx:lastIndx-1;
            int lowerBound = upperBound-((count-1)*2);
            return add_sumEven(arr, upperBound, lowerBound);
        }
        static int add_sum_helperF_odd(int[] arr, int count)
        {
            int upperBound = count * 2 - 1;
            int lowerBound = 0;
            return add_sumEven(arr, upperBound, lowerBound);
        }
        static int add_sum_helperB_odd(int[] arr, int count)
        {
            int lastIndx = arr.Length - 1;
            int upperBound = lastIndx%2==0? lastIndx-1:lastIndx;
            int lowerBound = upperBound -((count-1)*2);
            return add_sumEven(arr, upperBound, lowerBound);
        }
    }
}
