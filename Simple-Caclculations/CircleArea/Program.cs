﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = Double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
