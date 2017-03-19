using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "s3cr3t!P@ssw0rd";
            var input = Console.ReadLine();

            if (password == input)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
