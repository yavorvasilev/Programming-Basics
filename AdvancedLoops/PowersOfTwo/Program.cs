﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 1;
            Console.WriteLine(number);
            for (int i = 0; i < n; i++)
            {
                number*=2;
                Console.WriteLine(number);
            }
        }
    }
}
