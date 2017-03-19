using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var costForKgVegetable = double.Parse(Console.ReadLine());
            var costForKgFruit = double.Parse(Console.ReadLine());
            var vegetableProductionInKg = int.Parse(Console.ReadLine());
            var FruitProductionInKg = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}",(costForKgFruit * FruitProductionInKg + costForKgVegetable * vegetableProductionInKg) / 1.94);
        }
    }
}
