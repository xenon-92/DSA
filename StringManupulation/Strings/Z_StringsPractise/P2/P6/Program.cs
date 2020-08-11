using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string pattern = "<\\/{0,1}upcase>";
            Regex reg = new Regex(pattern);
            str = reg.Replace(str, "|");
            string result = MakeUpper(str);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static string MakeUpper(string str)
        {
            bool isUpper = false;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c == '|')
                {
                    isUpper = isUpper == false ? true : false;
                    continue;
                }
                if (isUpper)
                {
                    sb.Append(char.ToUpper(c));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
