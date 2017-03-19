using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = decimal.Parse(Console.ReadLine());
            var sex = Console.ReadLine();

            if ((sex == "f") && (age < 16 && age > 0 ))
            {
                Console.WriteLine("Miss");
            }
            else if ((sex == "f") && (age >= 16))
            {
                Console.WriteLine("Ms.");
            }
            else if ((sex == "m") && (age < 16 && age > 0))
            {
                Console.WriteLine("Master");
            }
            else if ((sex == "m") && (age >= 16))
            {
                Console.WriteLine("Mr.");
            }
        }
    }
}
