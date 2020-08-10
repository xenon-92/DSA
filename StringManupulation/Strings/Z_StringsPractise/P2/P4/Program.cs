using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            string[] strArr = str.Split(new char[] { '\\' });
            Console.ReadKey();
        }
    }
}
