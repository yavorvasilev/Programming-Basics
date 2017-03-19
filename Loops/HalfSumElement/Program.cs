using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
                sum += number;
            }
            if (maxNumber == (sum - maxNumber))
            {
                Console.WriteLine("Yes Sum = {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(maxNumber - (sum - maxNumber)));
            }
        }
    }
}
