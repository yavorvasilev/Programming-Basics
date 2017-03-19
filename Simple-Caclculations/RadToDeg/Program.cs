using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadToDeg
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = Double.Parse(Console.ReadLine());
            var deg = (rad * 180) / Math.PI;
            Console.WriteLine(Math.Round(deg));
        }
    }
}
