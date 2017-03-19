using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var ticketType = Console.ReadLine();
            var numberOfPeapleInGroup = int.Parse(Console.ReadLine());

            if (numberOfPeapleInGroup >= 1 && numberOfPeapleInGroup <= 4)
            {
                budget -= 0.75 * budget;
            }
            else if (numberOfPeapleInGroup >= 5 && numberOfPeapleInGroup <= 9)
            {
                budget -= 0.60 * budget;
            }
            else if (numberOfPeapleInGroup >= 10 && numberOfPeapleInGroup <= 24)
            {
                budget -= 0.50 * budget;
            }
            else if (numberOfPeapleInGroup >= 25 && numberOfPeapleInGroup <= 49)
            {
                budget -= 0.40 * budget;
            }
            else if (numberOfPeapleInGroup >= 50)
            {
                budget -= 0.25 * budget;
            }

            if (ticketType == "VIP")
            {
                if (numberOfPeapleInGroup * 499.99 > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", numberOfPeapleInGroup * 499.99 - budget);
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget - numberOfPeapleInGroup * 499.99);
                }
            }
            else
            {
                if (numberOfPeapleInGroup * 249.99 > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", numberOfPeapleInGroup * 249.99 - budget);
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget - numberOfPeapleInGroup * 249.99);
                }
            }
        }
    }
}
