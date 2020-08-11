using System;
using System.Text;

namespace P11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Microsoft announced its next generation C# compiler today.It uses advanced parser and special optimizer for the Microsoft CLR.";
            string[] forbiddenWords = { "C#","CLR","Microsoft"};
            StringBuilder sb = new StringBuilder(str);
            foreach (var item in forbiddenWords)
            {
                sb.Replace(item,string.Empty.PadRight(item.Length,'*'));
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
