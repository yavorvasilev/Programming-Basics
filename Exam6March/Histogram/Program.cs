using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0d; // < 200
            var p2 = 0d; // 200 … 399
            var p3 = 0d; // 400 … 599
            var p4 = 0d; // 600 … 799
            var p5 = 0d; // ≥ 800


            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }
            }
            var c = (p1 / n) * 100;
            Console.WriteLine("{0:0.00}%", (p1 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p2 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p3 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p4 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p5 / n) * 100);
        }
    }
}
