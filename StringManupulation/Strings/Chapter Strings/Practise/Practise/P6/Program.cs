using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P6
{
    // replace cases by regex with '|' 
    // apply logic to append to string builder
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string reg = Regex.Replace(str, "<\\/?\\w+\\>", "|");
            Console.WriteLine(MakeUpperCase(reg));
            Console.ReadKey();

        }
        static string MakeUpperCase(string reg)
        {
            StringBuilder sb = new StringBuilder(reg.Length);
            bool isUpper = false;
            for (int i = 0; i < reg.Length; i++)
            {
                if (reg[i] == '|')
                {
                    isUpper = isUpper == false ? true : false;
                    continue;
                }
                if (isUpper)
                {
                    sb.Append(char.ToUpper(reg[i]));
                }
                else
                {
                    sb.Append(reg[i]);
                }

            }
            return sb.ToString();
        }
    }
}
