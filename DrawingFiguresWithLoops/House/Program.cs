using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            if (n % 2 == 0)
            {
                var blanks = ((n - 2) / 2);
                var stars = 2;
                // first row
                Console.Write(new string('-', (n - 2) / 2));
                Console.Write(new string('*', stars));
                Console.Write(new string ('-', (n - 2)/2));
                Console.WriteLine();

                for (int row = 1; row <= (n / 2) - 1; row++)
                {
                    Console.Write(new string('-', blanks - 1));
                    Console.Write(new string('*', stars + 2));
                    Console.Write(new string('-', blanks - 1));
                    stars += 2;
                    blanks--;
                    Console.WriteLine();
                }

                for (int row = 1; row <= n / 2; row++)
                {
                    Console.Write('|');
                    Console.Write(new string ('*', n - 2));
                    Console.Write('|');
                    Console.WriteLine();
                }
                

            }
            else
            {
                var stars = 1;
                var blanks = (n / 2) - 1;
                Console.Write(new string('-', (n - 1) / 2));
                Console.Write(new string ('*', stars));
                Console.Write(new string('-', (n - 1) / 2));
                Console.WriteLine();

                for (int row = 1; row <= n / 2; row++)
                {
                    Console.Write(new string('-', blanks));
                    Console.Write(new string('*', stars + 2));
                    Console.Write(new string('-', blanks));
                    stars += 2;
                    blanks--;
                    Console.WriteLine();
                }

                for (int row = 1; row <= n / 2; row++)
                {
                    Console.Write('|');
                    Console.Write(new string('*', n - 2));
                    Console.Write('|');
                    Console.WriteLine();
                }
            }
            //Console.Write(new string('_', n - 1));
            //Console.Write(new string('*', ));
        
        }
    }
}
