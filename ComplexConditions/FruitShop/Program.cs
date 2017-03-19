using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = decimal.Parse(Console.ReadLine());
            var price = 0.00m;

            if (day == "sunday" || day == "saturday")
            {
                if (fruit == "banana")
                {
                    price = 2.70m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "apple")
                {
                    price = 1.25m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "orange")
                {
                    price = 0.90m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "grapes")
                {
                    price = 4.20m * quantity;
                    Console.WriteLine(price);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "apple")
                {
                    price = 1.20m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "orange")
                {
                    price = 0.85m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50m * quantity;
                    Console.WriteLine(price);
                }
                else if (fruit == "grapes")
                {
                    price = 3.85m * quantity;
                    Console.WriteLine(price);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
           
        }
    }
}
