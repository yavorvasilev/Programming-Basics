using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0d;
            var sum1 = 0d;
            var lastSum = 0d;
            var Diff = 0d;
            var maxDiff = 0d;
            var totalDiff = 0d;

            for (int i = 0; i < n; i++)
            {
                for (int c = 0; c < 2; c++)
                {
                    var number = double.Parse(Console.ReadLine());
                    sum += number; //  Current Sum;
                }
                //var number1 = double.Parse(Console.ReadLine());
                //var number2 = double.Parse(Console.ReadLine());
                //sum = number1 + number2;
                if ((sum != sum1) && (sum1 != 0))
                {
                    Diff = Math.Abs(sum - sum1);
                    if (Diff > maxDiff)
                    {
                        totalDiff = Diff;
                    }
                }
                else
                {
                    lastSum = sum;
                }
                sum1 = sum;
                maxDiff = Diff;
                sum = 0;

            }
            if (totalDiff != 0)
            {
                Console.WriteLine("No, maxdiff={0}",totalDiff);
            }
            else
            {
                Console.WriteLine("Yes, value={0}",lastSum);
            }
            //Console.WriteLine(totalDiff);
            //Console.WriteLine(lastSum);
        }
    }
}
