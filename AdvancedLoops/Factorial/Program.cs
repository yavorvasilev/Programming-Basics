using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var product = 1;

            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);
        }
    }
}
