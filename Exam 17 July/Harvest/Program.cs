using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
                var areaVineyards = int.Parse(Console.ReadLine());
                var grapesFrom1qm = double.Parse(Console.ReadLine());
                var neededLitreWine = int.Parse(Console.ReadLine());
                var numbersOfWorkers = int.Parse(Console.ReadLine());

                var areForWine = areaVineyards * 0.40;
                var productionOfGrapes = areForWine * grapesFrom1qm;
                var wineProduction = productionOfGrapes / 2.5;

                if (wineProduction >= neededLitreWine)
                {
                    Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineProduction));
                    Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineProduction - neededLitreWine), Math.Ceiling((wineProduction - neededLitreWine) / numbersOfWorkers));
                }
                else if (neededLitreWine > wineProduction-125)
                {
                    Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Truncate(neededLitreWine - wineProduction));
                }
            }
    }
}
