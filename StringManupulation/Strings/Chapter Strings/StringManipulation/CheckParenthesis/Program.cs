using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that checks whether the parentheses are placed
//correctly in an arithmetic expression
namespace CheckParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string exprsn = Console.ReadLine();
            char[] braces = { '(', ')' };
            int leftBrace = CountBraces(exprsn, braces[0]);
            int rightBrace = CountBraces(exprsn, braces[1]);
            if (leftBrace == rightBrace)
            {
                Console.WriteLine("Balanced");
            }
            else
            {
                Console.WriteLine("UnBalanced");
            }
            Console.ReadKey();

        }
        static int CountBraces(string str,char brace)
        {
            int count = 0;
            int index = str.IndexOf(brace);
            while (index != -1)
            {
                count++;
                index = str.IndexOf(brace,index+1);
            }
            return count;
        }
    }
}
