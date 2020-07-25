using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyString = "Hello World!";
            Console.WriteLine(MyString.PadLeft(10, '-'));
            Console.ReadKey();
        }
    }
}
