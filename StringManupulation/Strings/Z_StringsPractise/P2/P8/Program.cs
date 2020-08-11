using System;
using System.Text;

namespace P8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append("\\u"+((int)str[i]).ToString("X4"));
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
