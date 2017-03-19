using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0d;
            var p2 = 0d;
            var p3 = 0d;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:0.00}%", (p1 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p2 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p3 / n) * 100);
        }
    }
}
