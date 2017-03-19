using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var EvenSum = 0d;
            var EvenMin = 1000000000.0;
            var EvenMax = -1000000000.0;
            var OddSum = 0d;
            var OddMin = 1000000000.0;
            var OddMax = -1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    EvenSum += number;
                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }
                    if(number > EvenMax)
                    {
                        EvenMax = number;
                    }
                }
                else
                {
                    OddSum += number;
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                }
            }

            //Odd
            Console.WriteLine("OddSum = {0},", OddSum);
            if (OddMin == 1000000000.0)
            {
                Console.WriteLine("OddMin = No,");
            }
            else
            {
                Console.WriteLine("OddMin = {0},", OddMin);
            }
            if (OddMax == -1000000000.0)
            {
                Console.WriteLine("OddMax = No");
            }
            else
            {
                Console.WriteLine("OddMax = {0}", OddMax);
            }

            //Even
            Console.WriteLine("EvenSum = {0},", EvenSum);
            if (EvenMin == 1000000000.0)
            {
                Console.WriteLine("EvenMin = No,");
            }
            else
            {
                Console.WriteLine("EvenMin = {0},", EvenMin);
            }
            if (EvenMax == -1000000000.0)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMax = {0}", EvenMax);
            }
        }
    }
}
