using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var blank = n - 1;
            var stars = 1;

            for (int column = 0; column <= n; column++)
            {
                if (column == 0)
                {
                    //first row
                    Console.Write(new string(' ', n + 1));
                    Console.Write('|');
                }
                else
                {
                    Console.Write(new string(' ', blank));
                    Console.Write(new string ('*', stars));
                    Console.Write(" | ");
                    Console.Write(new string ('*', stars));
                    //for (int row = 0; row < n - 1; row++)
                    //{
                    //    Console.Write(new string ('*', blank));
                    //}
                    blank--;
                    stars++;
                }

                Console.WriteLine();
            }
        }
    }
}
