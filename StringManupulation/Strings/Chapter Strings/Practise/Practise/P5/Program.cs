using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string subStr = "in";
            int count = CountWords(str.ToLower(),subStr);
            Console.WriteLine(count);
            Console.ReadKey();
        }
        static int CountWords(string str, string subStr)
        {
            int count = 0;
            int indx = str.IndexOf(subStr);
            while (indx!=-1)
            {
                count++;
                indx = str.IndexOf(subStr,indx+1);
            }
            return count;
        }
    }
}
