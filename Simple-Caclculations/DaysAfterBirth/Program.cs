using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            //string text = "01-02-2015";
            string format = "dd-MM-yyyy";
            // return text.AddDays(1);
            DateTime after1000 = DateTime.ParseExact(text, format, CultureInfo.InvariantCulture);
            //DateTime text = DateTime.Parse(Console.ReadLine());
            after1000 = after1000.AddDays(1000);
            //Console.WriteLine("{0}-{1}-{2}", after1000.Day, after1000.Month, after1000.Year);
            Console.WriteLine(after1000.ToString(format));

            //var text = Console.ReadLine();
            //Console.WriteLine(text);

        }       
    }
}
