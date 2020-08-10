using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string result = MakeReverese(str);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static string MakeReverese(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length-1; i >=0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
