using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "((a+b)/5-d)";
            char openB = '(';
            char closeB = ')';
            int open =0, close = 0; 
            int indx = str.IndexOf(openB);
            while (indx!=-1)
            {
                open++;
                indx = str.IndexOf(openB,indx+1);
            }
            int clsIndx = str.IndexOf(closeB);
            while (clsIndx!=-1)
            {
                close++;
                clsIndx = str.IndexOf(closeB,clsIndx+1);
            }
            if (open == close)
            {
                Console.WriteLine("Balanced....");
            }
            else
            {
                Console.WriteLine("Unbalanced...");
            }
            Console.ReadKey();
        }
    }
}
