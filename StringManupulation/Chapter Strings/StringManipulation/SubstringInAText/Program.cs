using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that detects how many times a substring is contained in
//the text.
namespace SubstringInAText
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We are living in a yellow submarine. We don't have anything else.Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.".ToLower();
            string subStr = "in";
            int result = CountSubstring(str,subStr);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static int CountSubstring(string str,string subStr)
        {
            int count = 0;
            int index = str.IndexOf(subStr);
            while (index!=-1)
            {
                count++;
                index = str.IndexOf(subStr,index+1);
            }
            return count;
        }
    }
}
