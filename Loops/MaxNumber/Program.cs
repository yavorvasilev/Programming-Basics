﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
               // Console.WriteLine(maxNumber);
            }
            Console.WriteLine(maxNumber);
        }
    }
}
