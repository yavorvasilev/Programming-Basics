using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrameII
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int column = 0; column < n;  column++)
            {
                if (column == 0 || column == n - 1)
                {
                    for (int row = 0; row < n; row++)
                    {
                        if (row == 0 || row == n - 1)
                        {
                            Console.Write("+ ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    Console.WriteLine();

                }
                else
                {
                    for (int row = 0; row < n; row++)
                    {
                        if (row == 0 || row == n - 1)
                        {
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
