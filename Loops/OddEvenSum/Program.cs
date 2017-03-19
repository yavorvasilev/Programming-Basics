using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var even = 0;
            var odd = 0;
            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += number;
                }
                else
                {
                    odd += number;
                }
            }
            //Console.WriteLine( "{0}, {1}",odd, even);
            if (even == odd)
            {
                Console.WriteLine("Yes Sum = {0}", even);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(even - odd));
            }
        }
    }
}
