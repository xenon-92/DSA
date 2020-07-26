using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//A text is given.Write a program that modifies the casing of letters to
//uppercase at all places in the text surrounded by<upcase> and
//</upcase> tags. 
namespace UpperCaseProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string rgx = "<\\/{0,1}\\w+>";
            string replaced = Regex.Replace(str,rgx,"|");
            string result = UpperCase(replaced);
            Console.WriteLine(result);
            Console.ReadKey();
            
        }
        static string UpperCase(string str)
        {
            StringBuilder sb = new StringBuilder(str.Length);
            bool isUpper = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '|')
                {
                    isUpper = isUpper == false ? true : false;
                    continue;
                }
                if (isUpper)
                {
                    sb.Append(char.ToUpper(str[i]));
                }
                else
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
    }
}
