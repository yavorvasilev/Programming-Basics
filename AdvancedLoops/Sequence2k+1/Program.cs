using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 0;
            var sequence = 0;
            do
            {
                sequence = (2 * number + 1);
                if (sequence > n)
                {
                    break;
                }
                Console.WriteLine(sequence);
                number = sequence;
            } while (sequence <= n);

        }
    }
}
