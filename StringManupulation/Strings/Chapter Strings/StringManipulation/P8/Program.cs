using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                int ascii = str[i];
                string unicode = "\\u" + ascii.ToString("X4");
                sb.Append(unicode);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
