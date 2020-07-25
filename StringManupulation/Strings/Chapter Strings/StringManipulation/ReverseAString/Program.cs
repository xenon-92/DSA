using System;
using System.Text;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string resultIterative = ReverseString(str);
            Console.WriteLine(resultIterative);
            string resultRecursive = ReverseByRecursion(str.ToCharArray(),0,str.Length-1);
            Console.WriteLine(resultRecursive);
            Console.ReadKey();
        }
        static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
        static string ReverseByRecursion(char[] str,int low,int high)
        {
            if (low>high)
            {
                string ptr = new string(str);
                return ptr;
            }
            Swap(str,low,high);
            return ReverseByRecursion(str,low+1,high-1);
        }
        static void Swap(char[] str,int i,int j)
        {
            char temp = str[i];
            str[i] = str[j];
            str[j] = temp;
        }
    }
}
