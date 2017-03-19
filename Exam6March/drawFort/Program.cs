using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 3 || n == 4)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}", '/', new string('^', n / 2), "\\", '/', new string('^', n / 2), "\\");

                for (int i = 1; i <= n - 2; i++)
                {
                    Console.WriteLine("{0}{1}{2}", '|', new string(' ', (n * 2) - 2), '|');
                }

                Console.WriteLine("{0}{1}{2}{3}{4}{5}", "\\", new string('_', n / 2), '/', "\\", new string('_', n / 2), '/');
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", '/', new string('^', n / 2), "\\", new string('_', n / 2), '/', new string('^', n / 2), "\\");

                for (int i = 1; i <= n - 2; i++)
                {
                    if (i == n - 2)
                    {
                        Console.WriteLine("{0}{1}{2}{3}{4}", '|', new string(' ', n / 2 + 1), new string('_', n / 2), new string(' ', n / 2 + 1), '|');
                        break;
                    }

                    Console.WriteLine("{0}{1}{2}", '|', new string(' ', (n * 2) - 2), '|');
                   
                }

                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", "\\", new string('_', n / 2), '/', new string(' ', n / 2), "\\", new string('_', n / 2), '/');
            }
        }
    }
}
