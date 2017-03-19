using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfDays = int.Parse(Console.ReadLine());
            var restFoodKg = int.Parse(Console.ReadLine());
            var dogFoodForDaykg = double.Parse(Console.ReadLine());
            var catFoodForDaykg = double.Parse(Console.ReadLine());
            var turtleFoodForDaykg = double.Parse(Console.ReadLine());
            var eatedFoodKg = 0d;

            eatedFoodKg = catFoodForDaykg * numberOfDays + dogFoodForDaykg * numberOfDays + (turtleFoodForDaykg * numberOfDays) / 1000;

            if (restFoodKg >= eatedFoodKg)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(restFoodKg - eatedFoodKg));
            }
            else if (eatedFoodKg > restFoodKg)
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(eatedFoodKg - restFoodKg));
            }

        }
    }
}
