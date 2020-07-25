using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            System.String str = Console.ReadLine();
            string reversedIteratively = ReverseIteratively(str);
            Console.WriteLine(reversedIteratively);
            string reverserecursively = ReverseRecursively(str.ToCharArray(),0,str.Length-1);
            Console.WriteLine(reverserecursively);
            Console.ReadKey();
        }
        static string ReverseIteratively(string str)
        {
            StringBuilder sb = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        static string ReverseRecursively(char[] strArr, int low, int high)
        {
            if (low > high)
            {
                return new string(strArr);
            }
            SwapHelper(strArr,low,high);
            return ReverseRecursively(strArr, low + 1, high-1) ;

        }
        static void SwapHelper(char[] arr, int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
