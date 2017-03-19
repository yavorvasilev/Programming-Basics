using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var side1 = Math.Abs(x1 - x2);
            var side2 = Math.Abs(y1 - y2);
            //Console.WriteLine(side1);
            //Console.WriteLine(side2);
            var area = side1 * side2;
            var parameter = (2 * side2) + (2 * side1);
            Console.WriteLine(area);
            Console.WriteLine(parameter);
        }
    }
}
