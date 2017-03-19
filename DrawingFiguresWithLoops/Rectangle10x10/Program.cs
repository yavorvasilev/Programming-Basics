using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle10x10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                //Console.WriteLine('*');
            }
            
        }
    }
}
