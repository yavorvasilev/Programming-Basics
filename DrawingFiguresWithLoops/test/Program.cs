using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                var blanks = (n - 2) / 2;
                var blanksMidle = 2;

                var blanks1 = 0;
                var blanksMidle1 = n - 2;

                for (int column = 1; column <= n - 1; column++)
                {
                    if (column == 1 || column == n - 1)
                    {
                        // first & last row
                        Console.Write(new string('-', (n - 2) / 2));
                        Console.Write(new string('*', 2));
                        Console.Write(new string('-', (n - 2) / 2));
                        Console.WriteLine();
                    }
                  
                    
                    if (column > 1 && column <= ((n / 2) - 1))
                    {
                        Console.Write(new string('-', blanks - 1));
                        Console.Write('*');
                        Console.Write(new string('-', blanksMidle));
                        Console.Write('*');
                        Console.Write(new string('-', blanks - 1));

                        blanksMidle += 2;
                        blanks--;
                        Console.WriteLine();
                    }
                    else if (column > ((n / 2) - 1) && column < n - 1)
                    {
                        Console.Write(new string('-', blanks1));
                        Console.Write('*');
                        Console.Write(new string('-', blanksMidle1));
                        Console.Write('*');
                        Console.Write(new string('-', blanks1));

                        blanksMidle1 -= 2;
                        blanks1++;
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                var blanks = (n - 2) / 2;
                var blanksMidle = 1;

                var blanks1 = 0;
                var blanksMidle1 = n - 2;

                for (int column = 1; column <= n; column++)
                {
                    if (column == 1 || column == n)
                    {
                        // first & last row
                        Console.Write(new string('-', (n - 1) / 2));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', (n - 1) / 2));
                        Console.WriteLine();
                    }


                    if (column > 1 && column <= (n / 2))
                    {
                        Console.Write(new string('-', blanks));
                        Console.Write('*');
                        Console.Write(new string('-', blanksMidle));
                        Console.Write('*');
                        Console.Write(new string('-', blanks));

                        blanksMidle += 2;
                        blanks--;
                        Console.WriteLine();
                    }
                    else if (column > (n / 2) && column < n)
                    {
                        Console.Write(new string('-', blanks1));
                        Console.Write('*');
                        Console.Write(new string('-', blanksMidle1));
                        Console.Write('*');
                        Console.Write(new string('-', blanks1));

                        blanksMidle1 -= 2;
                        blanks1++;
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
