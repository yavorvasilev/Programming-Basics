using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 1;
            var br = 0;
            for (int column = 1; column <= n; column++)
            {
                for (int row = 1; row <= column; row++)
                {
                    br++;
                    Console.Write(number + " ");
                    number++;
                    if (br == n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (br == n)
                {
                    break;
                }

            }
        }
    }
}
