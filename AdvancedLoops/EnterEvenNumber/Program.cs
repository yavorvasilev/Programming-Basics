using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            try
            {
                Console.WriteLine("Enter even number: ");
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number!");
            }
                

            do
            {
                if (number % 2 == 0)
                {
                    break;
                }

                Console.WriteLine("The number is not even.");
                Console.WriteLine("Enter even number:");
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            } while (number % 2 != 0);
            Console.WriteLine("Even number entered: {0}", number);
        }
    }
}
