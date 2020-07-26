using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split('.');
            string result = MapDistinct(str, " in ");
            Console.WriteLine(result);
            string result1 = MapDistinctRegex(str, "in");
            Console.WriteLine(result1);
            Console.ReadKey();
        }
        static string MapDistinct(string[] strArr, string keyword)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strArr.Length; i++)
            {
                int indx = strArr[i].IndexOf(keyword);
                if (indx != -1)
                {
                    sb.Append(strArr[i]);
                    sb.Append(".\n");
                }
            }
            return sb.ToString().Trim();
        }
        //by using regex
        static string MapDistinctRegex(string[] strArr,string keyword)
        {
            Regex reg = new Regex("\\bin\\b");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strArr.Length; i++)
            {
                if (reg.IsMatch(strArr[i]))
                {
                    sb.Append(strArr[i]+".\n");
                }
            }
            return sb.ToString().Trim();
        }
    }
}
