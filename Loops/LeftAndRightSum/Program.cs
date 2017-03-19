using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum1 += number;

            }
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum2 += number;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }
            else
            {
                Console.WriteLine("No, Diff = {0}", Math.Abs(sum1 - sum2));
            }
        }
    }
}
