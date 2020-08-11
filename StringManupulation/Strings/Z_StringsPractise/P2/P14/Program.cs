using System;
using System.Text;

namespace P14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = "C# is not C++ and PHP is not Delphi".Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = strArr.Length-1; i >=0; i--)
            {
                sb.Append(strArr[i]);
                sb.Append(' ');
            }
            Console.WriteLine(sb.ToString().Trim());
            Console.ReadKey();
        }
    }
}
