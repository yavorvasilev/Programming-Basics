using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceSkumriq1Kg = double.Parse(Console.ReadLine());
            var priceCaca1Kg = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrid = double.Parse(Console.ReadLine());
            var kgMidi = int.Parse(Console.ReadLine());
            var costPalamud = 0d;
            var costSafrid = 0d;
            var total = 0d;

            costPalamud = (priceSkumriq1Kg + priceSkumriq1Kg * 0.60) * kgPalamud;
            costSafrid = (priceCaca1Kg + priceCaca1Kg * 0.80) * kgSafrid;

            total = costPalamud + costSafrid + kgMidi * 7.50;

            Console.WriteLine("{0:0.00}", total);

        }
    }
}
