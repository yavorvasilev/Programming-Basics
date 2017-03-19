using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfGroups = int.Parse(Console.ReadLine());
            var sumOfStudents = 0d;
            var car = 0d;
            var microbus = 0d;
            var smallBus = 0d;
            var bus = 0d;
            var train = 0d;

            for (int i = 1; i <= numberOfGroups; i++)
            {
                var numberOfStudents = int.Parse(Console.ReadLine());
                sumOfStudents += numberOfStudents;

                if (numberOfStudents <= 5)
                {
                    car += numberOfStudents;
                }
                else if (numberOfStudents >= 6 && numberOfStudents <= 12)
                {
                    microbus += numberOfStudents;
                }
                else if (numberOfStudents >= 13 && numberOfStudents <= 25)
                {
                    smallBus += numberOfStudents;
                }
                else if (numberOfStudents >= 26 && numberOfStudents <= 40)
                {
                    bus += numberOfStudents;
                }
                else if (numberOfStudents >= 41)
                {
                    train += numberOfStudents;
                }
            }

            Console.WriteLine("{0:0.00}%", (car / sumOfStudents) * 100 );
            Console.WriteLine("{0:0.00}%", (microbus / sumOfStudents) * 100);
            Console.WriteLine("{0:0.00}%", (smallBus / sumOfStudents) * 100);
            Console.WriteLine("{0:0.00}%", (bus / sumOfStudents) * 100);
            Console.WriteLine("{0:0.00}%", (train / sumOfStudents) * 100);

        }
    }
}
