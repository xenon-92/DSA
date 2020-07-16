using System;

namespace _1SumofAnArray
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
            int count = 4;
            //int ans = sum_arr(arr,count);
            //int ans = SumEven.Arranger(arr, count);
            int ans = SumOdd.OddArranger(arr, count);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        //sum of an array up to a certain count
        //ex - compute sum of first 4 numbers
        static int sum_arr(int[] arr, int count)
        {
            //base case
            if (count == 0)
            {
                return 0;
            }
            //recursive case
            return arr[count - 1] + sum_arr(arr, count - 1);
        }
    }
    class SumEven
    {
        // count the first 4 even number in the array
        // position 0,2,4,6

        public static int Arranger(int[] arr, int evenCount)
        {
            //we get the upper bound of the array by multiplying 2 to the even count
            // say first 3, hence upperbound = 3*2=6
            //but this 6, starts from number 2
            //i.e 2,4,6
            //but we need to include 0
            //3*2 - 2 = 4
            int upperBoundIndex = evenCount * 2 - 2;
            int result = sum_arrEvenPos(arr, upperBoundIndex);
            return result;
        }
        static int sum_arrEvenPos(int[] arr, int index)
        {
            if (index < 0)
            {
                return 0;
            }
            return arr[index] + sum_arrEvenPos(arr, index - 2);
        }
    }
    class SumOdd
    {
        //find sum of first four odd positioned number in an array
        // i.e at position 1,3,5,7
        //hence parameter count =4
        public static int OddArranger(int[] arr, int count)
        {
            //upperbound = count*2-1
            // if count =4
            // upperbound = 8-1=7
            //position are 7,5,3,1
            int upperBound = count * 2 - 1;
            return add_OddPosNums(arr, upperBound);

        }
        static int add_OddPosNums(int[] arr, int upperbound)
        {
            if (upperbound < 0)
            {
                return 0;
            }
            return arr[upperbound] + add_OddPosNums(arr, upperbound - 2);
        }
    }
}
