using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (;;)
            //{

                var hourExam = int.Parse(Console.ReadLine());
                var minExam = int.Parse(Console.ReadLine());
                var hourArrival = int.Parse(Console.ReadLine());
                var minArrival = int.Parse(Console.ReadLine());

                if (hourExam - hourArrival > 1)
                {
                    if (minArrival > minExam)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:{1:00} hours before the start", (hourExam - hourArrival) - 1, 60 - Math.Abs(minExam - minArrival));
                    }
                    else if (minArrival < minExam || minArrival == minExam)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:{1:00} hours before the start", hourExam - hourArrival, minExam - minArrival);
                    }
                    
                }
                else if (hourExam - hourArrival == 1)
                {
                    if (minExam > minArrival)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:{1:00} hours before the start", hourExam - hourArrival, minExam - minArrival);
                    }
                    else if (minExam == minArrival)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:{1:00} hours before the start", hourExam - hourArrival, minExam - minArrival);

                    }
                    else if ((minArrival > minExam) && (60 - Math.Abs(minExam - minArrival) <= 30))
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine("{0} minutes before the start", 60 - Math.Abs(minExam - minArrival));
                    }
                    else if ((minArrival > minExam) && (60 - Math.Abs(minExam - minArrival) > 30))
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0} minutes before the start", 60 - Math.Abs(minExam - minArrival));
                    }
                }
                else if (hourExam == hourArrival)
                {
                    if ((minExam > minArrival) && ((minExam - minArrival) <= 30))
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine("{0} minutes before the start", minExam - minArrival);
                    }
                    else if ((minExam > minArrival) && ((minExam - minArrival) > 30))
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0} minutes before the start", minExam - minArrival);
                    }
                    else if (minArrival > minExam)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine("{0} minutes after the start", minArrival - minExam);
                    }
                    else if (minArrival == minExam)
                    {
                        Console.WriteLine("On time");
                    }
                }
                else if (hourArrival > hourExam)
                {
                    if ((hourArrival - hourExam) == 1 && minArrival >= minExam)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine("{0}:{1:00} hours after the start", hourArrival - hourExam, minArrival - minExam);
                    }
                    else if ((hourArrival - hourExam) == 1 && minExam > minArrival)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine("{0} minutes after the start", 60 - Math.Abs(minExam - minArrival));
                    }
                    else if ((hourArrival - hourExam) > 1)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine("{0}:{1:00} hours after the start", hourArrival - hourExam, Math.Abs(minExam - minArrival));

                    }
                }
            }
        //}
    }
}
