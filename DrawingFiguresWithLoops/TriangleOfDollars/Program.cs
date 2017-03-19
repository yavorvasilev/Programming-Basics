using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int column = 1; column <= n; column++)
            {
                for (int row = 0; row < column; row++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
