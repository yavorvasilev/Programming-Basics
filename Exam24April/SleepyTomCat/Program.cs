using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayOff = int.Parse(Console.ReadLine());
            var timeForGameOnDayOff = dayOff * 127;
            //var workDay = 365 - dayOff;
            var timeForGameOnWorkDay = (365 - dayOff) * 63;
            var sumOfGameTime = timeForGameOnDayOff + timeForGameOnWorkDay;

            if (sumOfGameTime <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", (30000 - sumOfGameTime) / 60 , (30000 - sumOfGameTime) % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", (sumOfGameTime - 30000) / 60, (sumOfGameTime - 30000) % 60);
            }
        }
    }
}
