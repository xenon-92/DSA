using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckbalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char openB = '(';
            char closedB = ')';
            int open = CheckBalancedBrackets(str,openB);
            int closed = CheckBalancedBrackets(str,closedB);
            if (open != closed)
            {
                Console.WriteLine("unbalanced");
            }
            else
            {
                Console.WriteLine("Balanced");
            }
            Console.ReadKey();
        }
        static int CheckBalancedBrackets(string str,char brace)
        {
            int indx = str.IndexOf(brace);
            int count = 0;
            while (indx != -1)
            {
                count++;
                indx = str.IndexOf(brace,indx+1);
            }
            return count;
        }
    }
}
