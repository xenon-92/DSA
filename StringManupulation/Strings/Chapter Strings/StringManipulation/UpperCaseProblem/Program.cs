using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            string result = UpCase(str);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static string UpCase(string str)
        {
            string start = "<upcase>";
            string end = "</upcase>";
            int startIndx = str.IndexOf(start);
            int endIndex = str.IndexOf(end);
            StringBuilder sb = new StringBuilder(str);
            while (startIndx!=-1 && endIndex!=-1)
            {
                for (int i = startIndx+7; i < endIndex; i++)
                {
                    sb[i] = char.ToUpper(str[i]);
                }
                startIndx = str.IndexOf(start, startIndx+1);
                endIndex = str.IndexOf(end, endIndex+1);
            }
            string[] ptr = sb.ToString().Split(new string[] { start,end},StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sbr = new StringBuilder();
            foreach (var item in ptr)
            {
                sbr.Append(item);
            }
            return sbr.ToString();
        }
    }
}
