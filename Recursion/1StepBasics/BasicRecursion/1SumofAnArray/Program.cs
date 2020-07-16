using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1SumofAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
            int count = 4;
            int ans = sum_arr(arr,count);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        static int sum_arr(int[] arr, int count)
        {
            //base case
            if (count == 0)
            {
                return 0;
            }
            //recursive case
            return arr[count - 1] + sum_arr(arr,count-1);
        }
    }
}
