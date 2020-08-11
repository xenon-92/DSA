using System;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string find = "in";
            int indx = str.IndexOf(find);
            int count = 0;
            while (indx!=-1)
            {
                count++;
                indx = str.IndexOf(find,indx+1);
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
