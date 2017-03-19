using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometr = int.Parse(Console.ReadLine());
            var timeTravel = Console.ReadLine();

            if (timeTravel == "day")
            {
                var taxi = (0.79 * kilometr) + 0.70;
                var autobus = 0.09 * kilometr;
                var train = 0.06 * kilometr;

                if (kilometr < 20)
                {
                    Console.WriteLine(taxi);
                }
                else if (kilometr >= 20 && kilometr < 100)
                {
                    Console.WriteLine(autobus);
                }
                else if (kilometr >= 100)
                {
                    Console.WriteLine(train);
                }
            }
            else if (timeTravel == "night")
            {
                var taxi = (0.90 * kilometr) + 0.70;
                var autobus = 0.09 * kilometr;
                var train = 0.06 * kilometr;

                if (kilometr < 20)
                {
                    Console.WriteLine(taxi);
                }
                else if (kilometr >= 20 && kilometr < 100)
                {
                    Console.WriteLine(autobus);
                }
                else if (kilometr >= 100)
                {
                    Console.WriteLine(train);
                }
            }
        }
    }
}
