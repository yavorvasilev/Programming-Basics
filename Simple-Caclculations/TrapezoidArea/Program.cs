using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //(b1 + b2) * h / 2
            var b1 = Double.Parse(Console.ReadLine());
            var b2 = Double.Parse(Console.ReadLine());
            var h = Double.Parse(Console.ReadLine());
            var are = ((b1 + b2) * h) / 2;
            Console.WriteLine("Trapezoid are = " + are);
        }
    }
}
