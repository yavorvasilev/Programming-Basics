using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //first row
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();
            //midle

            for (int i = 0; i < n-2; i++)
            {
                Console.Write("| ");
                for (int c = 0; c < n - 2; c++)
                {
                    Console.Write("- ");
                }
                Console.Write("|");
                Console.WriteLine();

            }


            //last row
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();
        }
    }
}
