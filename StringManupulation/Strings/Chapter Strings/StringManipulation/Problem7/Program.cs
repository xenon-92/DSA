﻿using System;
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
            string str = Console.ReadLine();
            str = str.PadRight(20,'*');
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
