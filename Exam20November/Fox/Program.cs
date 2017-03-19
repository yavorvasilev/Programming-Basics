using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var blank = 2 * n - 1;
            var stars = n / 2;
            var midleStars = n;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', i));
                Console.Write("\\");
                Console.Write(new string('-',blank));
                Console.Write("/");
                Console.Write(new string('*', i));
                Console.WriteLine();
                blank -= 2;
            }
            blank = 2 * n - 1;

            for (int i = 1; i <= n / 3; i++)
            {
                Console.Write("|{0}\\{1}/{2}|", new string('*', stars), new string('*', midleStars), new string('*', stars));
                stars++;
                midleStars -= 2;
                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', i));
                Console.Write("\\");
                Console.Write(new string('*', blank));
                Console.Write("/");
                Console.Write(new string('-', i));
                Console.WriteLine();
                blank -= 2;
            }
        }
    }
}
