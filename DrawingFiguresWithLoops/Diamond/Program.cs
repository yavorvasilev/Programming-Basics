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

            if (n % 2 == 0)
            {
                var stars = 2;
                var blanks = (n - 2) / 2;
                var blanksMidle = 2;
                // first & last row
                Console.Write(new string('-', blanks));
                Console.Write(new string( '*', stars));
                Console.Write(new string('-', blanks));
                Console.WriteLine();

                for (int row = 1; row <= ((n / 2) - 1); row++)
                {
                    Console.Write(new string ('-', blanks - 1));
                    Console.Write('*');
                    Console.Write(new string('-', blanksMidle));
                    Console.Write('*');
                    Console.Write(new string('-', blanks - 1));

                    blanksMidle += 2;
                    blanks--;
                    Console.WriteLine();
                }

                stars = 2;
                blanks = (n - 2) / 2;
                blanksMidle = n / 2;

                for (int row = 1; row <= ((n / 2) - 2); row++)
                {
                    

                    Console.Write(new string('-', blanks - 2));
                    Console.Write('*');
                    Console.Write(new string('-', blanksMidle));
                    Console.Write('*');
                    Console.Write(new string('-', blanks - 1));

                    blanksMidle -= 2;
                    blanks++;
                    Console.WriteLine();
                }

                stars = 2;
                blanks = (n - 2) / 2;
                blanksMidle = 2;
                // first & last row
                Console.Write(new string('-', blanks));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', blanks));
                Console.WriteLine();


            }
        }
    }
}
