using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingStopFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = n + 1;
            var underLine = 2 * n - 1;
            for (int i = 1; i <= n + 1; i++)
            {
                Console.Write(new string ('.', stars ));
                if (i == 1)
                {
                    Console.Write(new string ('_', 2*n +1));
                    Console.Write(new string('.', stars));
                }
                else
                {
                    Console.Write("//");
                    Console.Write(new string ('_', underLine));
                    underLine += 2;
                    Console.Write('\u005c');
                    Console.Write('\u005c');
                    Console.Write(new string('.', stars));
                }
                Console.WriteLine();
                stars--;
            }
            Console.Write("//");
            Console.Write(new string('_', (underLine - 5) / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', (underLine - 5) / 2));
            Console.Write('\u005c');
            Console.Write('\u005c');
            Console.WriteLine();
            Console.Write('\u005c');
            Console.Write('\u005c');
            Console.Write(new string('_', underLine));
            Console.Write("//");
            Console.WriteLine();
            stars = 1;
            for (int i = 1; i < n; i++)
            {
                underLine -= 2;
                Console.Write(new string('.', stars));
                Console.Write('\u005c');
                Console.Write('\u005c');
                Console.Write(new string('_', underLine));
                Console.Write("//");
                Console.Write(new string('.', stars));
                stars++;
                Console.WriteLine();
            }
            
        }
    }
}
