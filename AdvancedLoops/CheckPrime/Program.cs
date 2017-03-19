using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var n = (int)(Math.Sqrt(number));
            var divisor = 0;
            if (number >= 2)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (number % i == 0)
                    {
                        divisor++;
                    }
                }
                if (divisor >= 1)
                {
                    Console.WriteLine("Not Prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
