using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {

            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            var total = time1 + time2 + time3;
            var min = 0m;
            var sec = 0d;
            if (total <= 59)
            {
                min = total / 60;
                sec = total % 60;
                if (sec < 10)
                {
                    Console.WriteLine("{0}:0{1}", min, sec);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", min, sec);
                }    
            }
            else if (total >= 60 && total <= 119)
            {
                min = total / 60;
                sec = total % 60;
                if (sec < 10)
                {
                    Console.WriteLine("{0}:0{1}", min, sec);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", min, sec);
                }
            }
            else if (total >= 120 && total <= 179)
            {
                min = total / 60;
                sec = total % 60;
                if (sec < 10)
                {
                    Console.WriteLine("{0}:0{1}", min, sec);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", min, sec);
                }
            }
        }
    }
}
