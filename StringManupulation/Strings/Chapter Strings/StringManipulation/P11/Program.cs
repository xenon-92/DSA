using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace P11
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sample input :  Microsoft announced its next generation C# compiler today.It uses advanced parser and special optimizer for the Microsoft CLR
            string str = Console.ReadLine();
            //sample input : C#, CLR, Microsoft
            string forbidden = Console.ReadLine();
            string result = Replacer(str,forbidden);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static string Replacer(string str,string forbidden)
        {
            string[] forbidArr = forbidden.Split(new char[] { ','},StringSplitOptions.RemoveEmptyEntries);
            
            
            for (int i = 0; i < forbidArr.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(forbidArr[i]))
                {
                    str = Regex.Replace(str, forbidArr[i].Trim(), string.Empty.PadRight(forbidArr[i].Trim().Length, '*'));
                }
            }
            return str;
        }
    }
}
