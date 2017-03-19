using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var total = 0d;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:0.00}", (30 * budget) / 100);
                }
                else
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:0.00}", (70 * budget) / 100);
                }
            }
            else if (budget <= 1000 && budget > 100 )
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:0.00}", (40 * budget) / 100);
                }
                else
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:0.00}", (80 * budget) / 100);
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:0.00}", (90 * budget) / 100);
            }
        }
    }
}
