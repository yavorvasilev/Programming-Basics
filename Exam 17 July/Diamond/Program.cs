using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var point = n;
            var stars = 3 * n;
            for (int i = 1; i <= 3 * n + 2; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("{0}{1}{2}", new string('.', point), new string('*', stars), new string('.', point));
                    point--;
                    stars += 2;
                }
                
                else if ( i >= 2 && i < n + 1)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('.', point), new string('.', stars - 2), new string('.', point));
                    point--;
                    stars += 2;
                }
                else if (i == n + 1)
                {
                    Console.WriteLine(new string('*', 5 * n));
                }
                else if (i > n + 1 && i < 3 * n + 2)
                {
                    point++;
                    stars -= 2;
                    Console.WriteLine("{0}*{1}*{2}", new string('.', point), new string('.', stars - 2), new string('.', point));
                    
                }
                else if (i == 3 * n + 2)
                {
                    point++;
                    Console.WriteLine("{0}{1}{2}", new string('.', point), new string('*', n - 2), new string('.', point));
                }
                
            }
        }
    }
}
