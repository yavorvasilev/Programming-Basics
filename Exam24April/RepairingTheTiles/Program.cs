using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var o = int.Parse(Console.ReadLine());

            var neededPlates = ((n * n) - (m * o)) / (w * l);
            var neededTime = (neededPlates * 0.2);
            Console.WriteLine(neededPlates);
            Console.WriteLine(neededTime);
        }
    }
}
