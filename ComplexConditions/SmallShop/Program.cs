﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        { 
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var price = 0d;

            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.50;
                    Console.WriteLine(price);
                }
                else if (product == "water")
                {
                    price = quantity * 0.80;
                    Console.WriteLine(price);
                }
                else if (product == "beer")
                {
                    price = quantity * 1.20;
                    Console.WriteLine(price);
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.45;
                    Console.WriteLine(price);
                }
                else if (product == "peanuts")
                {
                    price = quantity * 1.60;
                    Console.WriteLine(price);
                }
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.40;
                    Console.WriteLine(price);
                }
                else if (product == "water")
                {
                    price = quantity * 0.70;
                    Console.WriteLine(price);
                }
                else if (product == "beer")
                {
                    price = quantity * 1.15;
                    Console.WriteLine(price);
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.30;
                    Console.WriteLine(price);
                }
                else if (product == "peanuts")
                {
                    price = quantity * 1.50;
                    Console.WriteLine(price);
                }
            }
            else if (city == "varna")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.45;
                    Console.WriteLine(price);
                }
                else if (product == "water")
                {
                    price = quantity * 0.70;
                    Console.WriteLine(price);
                }
                else if (product == "beer")
                {
                    price = quantity * 1.10;
                    Console.WriteLine(price);
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.35;
                    Console.WriteLine(price);
                }
                else if (product == "peanuts")
                {
                    price = quantity * 1.55;
                    Console.WriteLine(price);
                }
            }
        }
    }
}
