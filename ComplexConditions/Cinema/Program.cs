using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());

            if (projection == "premiere")
            {
                Console.WriteLine("{0} leva", Math.Round (12.00m * row * column,2));
            }
            else if (projection == "normal")
            {
                Console.WriteLine("{0} leva", Math.Round(7.50m * row * column, 2));
            }
            else if (projection == "discount")
            {
                Console.WriteLine("{0} leva", Math.Round(5.00m * row * column, 2));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
