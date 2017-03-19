using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int column = 1; column <= n; column++)
            {
                if (column == 1 || column == n)
                {
                    // first and last row
                    Console.Write(new string('*', 2*n));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', 2*n));
                }
                else
                {
                    // one glass
                    Console.Write('*');
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write('*');

                    //midle

                    if (( n % 2 == 0) && (column == n / 2))
                    {
                        Console.Write(new string('|', n));
                    }
                    else if ((n % 2 != 0) && (column == (n % 2) + (n / 2)))
                    {
                        Console.Write(new string('|', n));
                    }
                    else
                    {
                        Console.Write(new string(' ', n));
                    }

                    // second glass
                    Console.Write('*');
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
