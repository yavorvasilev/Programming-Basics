using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timePlus15Minuts
{
    class Program
    {
        static void Main(string[] args)
        {

            var hour = int.Parse(Console.ReadLine()); //12
            var minuts = int.Parse(Console.ReadLine()); //45

            minuts += 15;

            if (minuts >= 60)
            {
                minuts -= 60;
                hour += 1;

                if (hour > 23)
                {
                    hour = 0;

                    if (minuts >= 0 && minuts <= 9)
                    {
                        Console.WriteLine("{0}:0{1}", hour, minuts);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", hour, minuts);
                    }
                }
                else
                {
                    if (minuts >= 0 && minuts <= 9)
                    {
                        Console.WriteLine("{0}:0{1}", hour, minuts);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", hour, minuts);
                    }
                }
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour , minuts);
            }
        }
    }
}
