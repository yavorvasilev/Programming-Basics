using System;

class StupidPasswordGenerator
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var number = n;
        var row = n / 100 + (n / 10) % 10;
        var column = n / 100 + n % 10;

        for (int i1 = 1; i1 <= row; i1++)
        {
            for (int i2 = 1; i2 <= column; i2++)
            {
                if (number % 5 == 0)
                {
                    number = number - n / 100;
                    Console.Write("{0} ", number);
                }
                else if (number % 3 == 0)
                {
                    number = number - (n / 10) % 10;
                    Console.Write("{0} ", number);
                }
                else
                {
                    number = number + n % 10;
                    Console.Write("{0} ", number);
                }

            }
            Console.WriteLine();
        }
    }
}

