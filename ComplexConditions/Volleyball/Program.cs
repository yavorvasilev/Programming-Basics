using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfyear = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var weekOfPlaye = 0d;

            if (typeOfyear == "leap")
            {
                weekOfPlaye = (48 - h) * 3.0/4;
                weekOfPlaye += h;
                weekOfPlaye += p * (2.0 / 3);
                weekOfPlaye += weekOfPlaye * 0.15;
                Console.WriteLine(Math.Truncate(weekOfPlaye));
            }
            else if (typeOfyear == "normal")
            {
                weekOfPlaye = (48 - h) * 3.0 / 4;
                weekOfPlaye += h;
                weekOfPlaye += p * (2.0 / 3);
                Console.WriteLine(Math.Truncate(weekOfPlaye));
            }        
        }
    }
}
