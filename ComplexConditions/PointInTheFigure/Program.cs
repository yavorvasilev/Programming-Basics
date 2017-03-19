using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var border1x1 = (x == 2 * h && (y <= (4 * h) && y >= h));
            var border1x2 = (x == h && (y <= (4 * h) && y >= h));
            var border1y1 = (y == 4*h && x <= 2 * h && x >= h);

            var border2x1 = (x == 3 * h && y <= h && y >= 0);
            var border2x2 = (x == 0 && y <= h && y >= 0);
            var border2y1 = (y == h && x <= 3 * h && x >= 0);
            var border2y2 = (y == 0 && x <= 3 * h && x >= 0);

            if ((x < (2 * h) && y< (4 * h) && x > h && y >= h ) || ((x < (3 * h) && y < h)) && (x > 0 && y >0))
            {
                Console.WriteLine("inside");
            }
            else if (border1x1 || border1x2 || border1y1 || border2x1 || border2x2 || border2y1 || border2y2)
            {
                Console.WriteLine("border");
            }
            //else if ((x == 2*h && (y <= (4 * h) && y >= h ) || x == h && (y <= (4 * h) && y >= h)) || (x == (4 * h) && (y <= h && y >= 0 )) || x == 0 && y <= h && y >= 0)
            //{
            //    Console.WriteLine("border");
            //}

            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
