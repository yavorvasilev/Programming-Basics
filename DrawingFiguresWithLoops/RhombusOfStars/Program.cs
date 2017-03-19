using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int column = 1; column <= n; column++)
            {
                Console.Write(new string(' ', n - column));
                Console.Write('*');
                for (int row = 1; row <= column - 1; row++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int column = 1; column <= n - 1; column++)
            {
                Console.Write(new string (' ', column));
                Console.Write('*');
                for (int row = 1; row <=  n - 1 - column; row++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
