using System;

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
