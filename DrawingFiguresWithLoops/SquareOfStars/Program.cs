using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int c = 0; c < n; c++)
            {
                for (int r = 0; r < n; r++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
           
        }
    }
}
