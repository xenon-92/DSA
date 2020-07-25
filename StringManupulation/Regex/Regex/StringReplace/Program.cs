using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "I have lost $6788 but gained $989008080";
            string reg = "\\$\\d+\\b";
            string replacedDoc = Regex.Replace(str,reg,"****");
            Console.WriteLine(replacedDoc);
            Console.ReadKey();
        }
    }
}
