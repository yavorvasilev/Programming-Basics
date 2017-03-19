using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatesCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = 0;

            do
            {
                if (a == b)
                {
                    break;
                }
                 else if (a > b)
                {
                    c = a % b;
                    if (c == 0)
                    {

                        break;
                    }
                    else if (c > b)
                    {
                        a = c;
                    }
                    else if (c < b)
                    {
                        a = b;
                        b = c;
                    }
                }
                else
                {
                   c = b % a;
                   if (c == 0)
                   {
                        b = a;
                        break;
                   }
                   else if (c > b)
                   {
                        a = c;
                   }
                   else if (c < b)
                   {
                        a = b;
                        b = c;
                   }

                }
            } while (c != 0);
            Console.WriteLine(b);
        }
    }
}
