using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = decimal.Parse(Console.ReadLine());
            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine(0.05m * sales);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine(0.07m * sales);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine(0.08m * sales);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine(0.12m * sales);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine(Math.Round(0.045m * sales,2));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine(Math.Round(0.075m * sales,2));
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine(0.10m * sales);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine(0.13m * sales);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine(Math.Round(sales * 0.055m, 2));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine(0.08m * sales);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine(0.12m * sales);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine(Math.Round(0.145m * sales,2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
