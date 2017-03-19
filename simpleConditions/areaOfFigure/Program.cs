using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfFigure = Console.ReadLine();

            if (typeOfFigure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a*a);
            }
            if (typeOfFigure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a*b);
            }
            if (typeOfFigure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * (r * r),3));
            }
            if (typeOfFigure == "triangle")
            {
                var h = double.Parse(Console.ReadLine());
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine( (a * h) / 2);
            }
        }
    }
}
