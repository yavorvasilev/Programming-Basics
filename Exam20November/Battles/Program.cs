using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPokemonsFirstPlayer = int.Parse(Console.ReadLine());
            var numberOfPokemonsSecondPlayer = int.Parse(Console.ReadLine());
            var stopNumber = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i1 = 1; i1 <= numberOfPokemonsFirstPlayer; i1++)
            {
                for (int i2 = 1; i2 <= numberOfPokemonsSecondPlayer; i2++)
                {
                    if (count >= stopNumber)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ",i1, i2);
                    count++;
                }
            }
            Console.WriteLine();

        }
    }
}
