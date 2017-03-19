using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberToText100
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            if (number > 100 || number < 0)
            {
                Console.WriteLine("invalid number");
            }
                if ((number / 10) == 0 || (number / 10) == 1)
                {
                    if (number == 0)
                    {
                        Console.WriteLine("zero");
                    }
                    else if (number == 1)
                    {
                        Console.WriteLine("one");
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("two");
                    }
                    else if (number == 3)
                    {
                        Console.WriteLine("three");
                    }
                    else if (number == 4)
                    {
                        Console.WriteLine("four");
                    }
                    else if (number == 5)
                    {
                        Console.WriteLine("five");
                    }
                    else if (number == 6)
                    {
                        Console.WriteLine("six");
                    }
                    else if (number == 7)
                    {
                        Console.WriteLine("seven");
                    }
                    else if (number == 8)
                    {
                        Console.WriteLine("eight");
                    }
                    else if (number == 9)
                    {
                        Console.WriteLine("nine");
                    }
                    else if (number == 10)
                    {
                        Console.WriteLine("ten");
                    }
                }
                if ((number / 10) == 2)
                {
                    if (number % 10 == 1)
                    {
                        Console.WriteLine("twenty one");
                    }
                    else if (number % 10 == 2)
                    {
                        Console.WriteLine("twenty two");
                    }
                    else if (number % 10 == 3)
                    {
                        Console.WriteLine("twenty three");
                    }
                    else if (number % 10 == 4)
                    {
                        Console.WriteLine("twenty four");
                    }
                    else if (number % 10 == 5)
                    {
                        Console.WriteLine("twenty five");
                    }
                    else if (number % 10 == 6)
                    {
                        Console.WriteLine("twenty six");
                    }
                    else if (number % 10 == 7)
                    {
                        Console.WriteLine("twenty seven");
                    }
                    else if (number % 10 == 8)
                    {
                        Console.WriteLine("twenty eight");
                    }
                    else if (number % 10 == 9)
                    {
                        Console.WriteLine("twenty nine");
                    }
                    else if (number == 20)
                    {
                        Console.WriteLine("twenty");
                    }
                }
                if ((number / 10) == 3)
                {
                    if (number % 10 == 1)
                    {
                        Console.WriteLine("thirty one");
                    }
                    else if (number % 10 == 2)
                    {
                        Console.WriteLine("thirty two");
                    }
                    else if (number % 10 == 3)
                    {
                        Console.WriteLine("thirty three");
                    }
                    else if (number % 10 == 4)
                    {
                        Console.WriteLine("thirty four");
                    }
                    else if (number % 10 == 5)
                    {
                        Console.WriteLine("thirty five");
                    }
                    else if (number % 10 == 6)
                    {
                        Console.WriteLine("thirty six");
                    }
                    else if (number % 10 == 7)
                    {
                        Console.WriteLine("thirty seven");
                    }
                    else if (number % 10 == 8)
                    {
                        Console.WriteLine("thirty eight");
                    }
                    else if (number % 10 == 9)
                    {
                        Console.WriteLine("thirty nine");
                    }
                    else if (number == 30)
                    {
                        Console.WriteLine("thirty");
                    }
                }
                if ((number / 10) == 4)
                {
                    if (number % 10 == 1)
                    {
                        Console.WriteLine("fourty one");
                    }
                    else if (number % 10 == 2)
                    {
                        Console.WriteLine("fourty two");
                    }
                    else if (number % 10 == 3)
                    {
                        Console.WriteLine("fourty three");
                    }
                    else if (number % 10 == 4)
                    {
                        Console.WriteLine("fourty four");
                    }
                    else if (number % 10 == 5)
                    {
                        Console.WriteLine("fourty five");
                    }
                    else if (number % 10 == 6)
                    {
                        Console.WriteLine("fourty six");
                    }
                    else if (number % 10 == 7)
                    {
                        Console.WriteLine("fourty seven");
                    }
                    else if (number % 10 == 8)
                    {
                        Console.WriteLine("fourty eight");
                    }
                    else if (number % 10 == 9)
                    {
                        Console.WriteLine("fourty nine");
                    }
                    else if (number == 40)
                    {
                        Console.WriteLine("fourty");
                    }
                }
                if ((number / 10) == 5)
                {
                    if (number % 10 == 1)
                    {
                        Console.WriteLine("fifty one");
                    }
                    else if (number % 10 == 2)
                    {
                        Console.WriteLine("fifty two");
                    }
                    else if (number % 10 == 3)
                    {
                        Console.WriteLine("fifty three");
                    }
                    else if (number % 10 == 4)
                    {
                        Console.WriteLine("fifty four");
                    }
                    else if (number % 10 == 5)
                    {
                        Console.WriteLine("fifty five");
                    }
                    else if (number % 10 == 6)
                    {
                        Console.WriteLine("fifty six");
                    }
                    else if (number % 10 == 7)
                    {
                        Console.WriteLine("fifty seven");
                    }
                    else if (number % 10 == 8)
                    {
                        Console.WriteLine("fifty eight");
                    }
                    else if (number % 10 == 9)
                    {
                        Console.WriteLine("fifty nine");
                    }
                    else if (number == 50)
                    {
                        Console.WriteLine("fifty");
                    }
                }
                if ((number / 10) == 6)
                {
                    if (number % 10 == 1)
                    {
                        Console.WriteLine("sixty one");
                    }
                    else if (number % 10 == 2)
                    {
                        Console.WriteLine("sixty two");
                    }
                    else if (number % 10 == 3)
                    {
                        Console.WriteLine("sixty three");
                    }
                    else if (number % 10 == 4)
                    {
                        Console.WriteLine("sixty four");
                    }
                    else if (number % 10 == 5)
                    {
                        Console.WriteLine("sixty five");
                    }
                    else if (number % 10 == 6)
                    {
                        Console.WriteLine("sixty six");
                    }
                    else if (number % 10 == 7)
                    {
                        Console.WriteLine("sixty seven");
                    }
                    else if (number % 10 == 8)
                    {
                        Console.WriteLine("sixty eight");
                    }
                    else if (number % 10 == 9)
                    {
                        Console.WriteLine("sixty nine");
                    }
                    else if (number == 60)
                    {
                        Console.WriteLine("sixty");
                    }
                }
                if ((number / 10) == 7)
                {
                    if (number % 10 == 1)
                    {
                        Console.WriteLine("seventy one");
                    }
                    else if (number % 10 == 2)
                    {
                        Console.WriteLine("seventy two");
                    }
                    else if (number % 10 == 3)
                    {
                        Console.WriteLine("seventy three");
                    }
                    else if (number % 10 == 4)
                    {
                        Console.WriteLine("seventy four");
                    }
                    else if (number % 10 == 5)
                    {
                        Console.WriteLine("seventy five");
                    }
                    else if (number % 10 == 6)
                    {
                        Console.WriteLine("seventy six");
                    }
                    else if (number % 10 == 7)
                    {
                        Console.WriteLine("seventy seven");
                    }
                    else if (number % 10 == 8)
                    {
                        Console.WriteLine("seventy eight");
                    }
                    else if (number % 10 == 9)
                    {
                        Console.WriteLine("seventy nine");
                    }
                    else if (number == 70)
                    {
                        Console.WriteLine("seventy");
                    }
                }
                if (number >= 90 && number <= 100)
                {
                    if (number % 10 == 1)
                    {
                        Console.WriteLine("ninety one");
                    }
                    else if (number % 10 == 2)
                    {
                        Console.WriteLine("ninety two");
                    }
                    else if (number % 10 == 3)
                    {
                        Console.WriteLine("ninety three");
                    }
                    else if (number % 10 == 4)
                    {
                        Console.WriteLine("ninety four");
                    }
                    else if (number % 10 == 5)
                    {
                        Console.WriteLine("ninety five");
                    }
                    else if (number % 10 == 6)
                    {
                        Console.WriteLine("ninety six");
                    }
                    else if (number % 10 == 7)
                    {
                        Console.WriteLine("ninety seven");
                    }
                    else if (number % 10 == 8)
                    {
                        Console.WriteLine("ninety eight");
                    }
                    else if (number % 10 == 9)
                    {
                        Console.WriteLine("ninety nine");
                    }
                    else if (number == 90)
                    {
                        Console.WriteLine("ninety");
                    }
                else if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
            }
                if ((number / 10) == 8)
                {
                    if (number % 10 == 1)
                    {
                        Console.WriteLine("eighty one");
                    }
                    else if (number % 10 == 2)
                    {
                        Console.WriteLine("eighty two");
                    }
                    else if (number % 10 == 3)
                    {
                        Console.WriteLine("eighty three");
                    }
                    else if (number % 10 == 4)
                    {
                        Console.WriteLine("eighty four");
                    }
                    else if (number % 10 == 5)
                    {
                        Console.WriteLine("eighty five");
                    }
                    else if (number % 10 == 6)
                    {
                        Console.WriteLine("eighty six");
                    }
                    else if (number % 10 == 7)
                    {
                        Console.WriteLine("eighty seven");
                    }
                    else if (number % 10 == 8)
                    {
                        Console.WriteLine("eighty eight");
                    }
                    else if (number % 10 == 9)
                    {
                        Console.WriteLine("eighty nine");
                    }
                    else if (number == 80)
                    {
                        Console.WriteLine("eighty");
                    }
                }
            if (number >= 11 && number <= 19)
            {
                if (number == 11)
                {
                    Console.WriteLine("eleven");
                }
                else if (number == 12)
                {
                    Console.WriteLine("twelve");
                }
                else if (number == 13)
                {
                    Console.WriteLine("thirteen");
                }
                else if (number == 14)
                {
                    Console.WriteLine("fourteen");
                }
                else if (number == 15)
                {
                    Console.WriteLine("fifteen");
                }
                else if (number == 16)
                {
                    Console.WriteLine("sixteen");
                }
                else if (number == 17)
                {
                    Console.WriteLine("seventeen");
                }
                else if (number == 18)
                {
                    Console.WriteLine("eighteen");
                }
                else if (number == 19)
                {
                    Console.WriteLine("nineteen");
                }
            }
        }            
    }
}
