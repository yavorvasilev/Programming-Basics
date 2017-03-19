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
            var n = int.Parse(Console.ReadLine());
            for (int r = 0; r < n; r++)
            {
                Console.WriteLine(new string ('*', n));
            }

        }
    }
}
