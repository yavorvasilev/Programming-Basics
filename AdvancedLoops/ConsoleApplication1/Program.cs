using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 3.8;
            var c = (int)n;

            Console.WriteLine(Math.Round(n,0));
            Console.WriteLine(Math.Round(n));
            Console.WriteLine(c);
        }
    }
}
