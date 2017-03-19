using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPiped
{
    class Program
    {
        static void Main(string[] args)
        {

            for (;;)
            {


                var v = int.Parse(Console.ReadLine());
                var p1 = int.Parse(Console.ReadLine());
                var p2 = int.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());

                var waterP1 = h * p1;
                var waterP2 = h * p2;
                var waterFromPipes = waterP1 + waterP2;

                if (waterFromPipes <= v)
                {
                    Console.WriteLine("The pool is {0}% full. Pipe 1: {1:0}%. Pipe 2: {2:0}%.", Math.Truncate((waterFromPipes / v) * 100), Math.Truncate((waterP1 / waterFromPipes) * 100), Math.Truncate((waterP2 / waterFromPipes) * 100));
                }
                else
                {
                    Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, (h * p1 + h * p2) - v);
                }
            }
         }
     }
}
