using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Fact(5);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        static int Fact(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return n * Fact(n-1);
        }
    }
}
