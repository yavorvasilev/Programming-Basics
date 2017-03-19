using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var sign = Console.ReadLine();
            var result = 0d;
            switch (sign)
            {
                case "+":
                    result = n1 + n2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} {1} {2} = {3} - even", n1, sign, n2, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3} - odd", n1, sign, n2, result);
                    }

                    break;
                case "-":
                    result = n1 - n2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} {1} {2} = {3} - even", n1, sign, n2, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3} - odd", n1, sign, n2, result);
                    }

                    break;
                case "*":
                    result = n1 * n2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} {1} {2} = {3} - even", n1, sign, n2, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3} - odd", n1, sign, n2, result);
                    }
                    break;
                case "/":
                    result = (double) n1 / n2;

                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3:0.00}", n1, sign, n2, result);
                    }

                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine("{0} {1} {2} = {3}", n1, sign, n2, result);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
