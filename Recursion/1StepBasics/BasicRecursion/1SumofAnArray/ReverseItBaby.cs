using System;

namespace _1SumofAnArray
{
    class ReverseItBaby
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int count = 2;
            //int ans = Arranger(arr,count);
            int ans = ReverseOdd.Arranger(arr,count);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        // find the sum of last 4 element of the array
        // count =4
        static int Arranger(int[] arr, int count)
        {
            //upper bound = arr.Length-1;
            //lower bound = upperbound - count + 1;
            int upperBound = arr.Length - 1;
            int lowerBound = upperBound - count + 1;
            return add_arrFromReverse(arr, upperBound, lowerBound);

        }
        static int add_arrFromReverse(int[] arr, int upperBound, int lowerBound)
        {
            if (lowerBound > upperBound)
            {
                return 0;
            }
            return arr[upperBound] + add_arrFromReverse(arr, upperBound - 1, lowerBound);
        }
    }

    //Add the last four add number of the array
    class ReverseOdd
    {
        //count referes to, the last n odd numbers
        //count the last 3 odd numbers
        public static int Arranger(int[] arr,int count)
        {
            int lastIndex = arr.Length - 1;
            int upperBound = lastIndex % 2 == 0 ? lastIndex - 1 : lastIndex;
            int lowerBound = upperBound - ((count-1)*2);
            return add_last_N_oddNums(arr,upperBound,lowerBound);
        }
        static int add_last_N_oddNums(int[] arr,int upperBound,int lowerBound)
        {
            if (lowerBound > upperBound)
            {
                return 0;
            }
            return arr[upperBound] + add_last_N_oddNums(arr,upperBound-2,lowerBound);
        }
    }
}
