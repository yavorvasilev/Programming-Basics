using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lastDigit = 0;
            var overage = 0;
            var sum = 0;

            do
            {

                lastDigit = n % 10;
                sum += lastDigit;
                //Console.WriteLine(lastDigit);
                overage = n / 10;
                //Console.WriteLine(h);
                n = overage;
            } while (overage > 0);
            Console.WriteLine(sum);
        }
    }
}
