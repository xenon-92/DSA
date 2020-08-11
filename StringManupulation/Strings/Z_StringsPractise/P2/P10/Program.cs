using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string pattern = " in ";
            Regex reg = new Regex(pattern);
            string[] strArr = str.Split('.');
            StringBuilder sb = new StringBuilder();
            foreach (string st in strArr)
            {
                if (reg.IsMatch(st))
                {
                    sb.Append(st);
                    sb.Append('.');
                }
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
