using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var blank = 5 * n - 3 * n - 2;
            var minus = 3 * n;
            var midle = n - 1;
            var last = n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', 3*n));
                Console.Write("*");
                Console.Write(new string('-', i - 1));
                Console.Write("*");
                Console.Write(new string('-', blank));
                Console.WriteLine();

                blank--;
            }

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}*{2}", new string('*', 3 * n + 1), new string('-', n - 1), new string('-', n - 1));
            }


            for (int i = 1; i <= n / 2; i++)
            {
                if (i == n / 2)
                {
                    Console.Write(new string('-', minus));
                    Console.Write("*");
                    Console.Write(new string('*', midle));
                    Console.Write("*");
                    Console.Write(new string('-', last));
                    break;
                }
                Console.Write(new string('-', minus));
                Console.Write("*");
                Console.Write(new string('-', midle));
                Console.Write("*");
                Console.Write(new string('-', last));
                midle += 2;
                minus--;
                last--;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
