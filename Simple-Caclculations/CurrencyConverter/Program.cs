using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = Double.Parse(Console.ReadLine());
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            Double total = 0;
            //Console.WriteLine(amount + " " + first + " " + " " + second);

            if (first == "BGN")
            {
                if (second == "EUR")
                {
                    total = amount / 1.95583;
                    Console.WriteLine(Math.Round(total, 2) + " " + second);
                }
                if (second == "USD")
                {
                    total = amount / 1.79549;
                    Console.WriteLine(Math.Round(total, 2) + " " + second);
                }
                if (second == "GBP")
                {
                    total = amount / 2.53405;
                    Console.WriteLine(Math.Round(total, 2) + " " + second);
                }
            }
            if (first == "USD")
            {
                if (second == "EUR")
                {
                    total = Math.Round((amount * 1.79549), 2) / 1.95583;
                    Console.WriteLine(Math.Round(total, 2) + " " + second);
                }
                if (second == "BGN")
                {
                    total = amount * 1.79549;
                    Console.WriteLine(Math.Round(total, 2) + " " + second);
                }
                if (second == "GBP")
                {
                    total = Math.Round((amount * 1.79549), 2) / 2.53405;
                    Console.WriteLine(Math.Round(total, 2) + " " + second);
                }
            }
            if (first == "EUR")
            {
                    if (second == "USD")
                    {
                        total = Math.Round((amount * 1.95583), 2) / 1.79549;
                        Console.WriteLine(Math.Round(total, 2) + " " + second);
                    }
                    if (second == "BGN")
                    {
                        total = amount * 1.95583;
                        Console.WriteLine(Math.Round(total, 2) + " " + second);
                    }
                    if (second == "GBP")
                    {
                        total = Math.Round((amount * 1.95583), 2) / 2.53405;
                        Console.WriteLine(Math.Round(total, 2) + " " + second);
                    }
              }
            if (first == "GBP")
            {
                if (second == "USD")
                {
                    total = Math.Round((amount * 2.53405), 2) / 1.79549;
                    Console.WriteLine(Math.Round(total, 2) + " " + second);
                }
                if (second == "BGN")
                {
                    total = amount / 2.53405;
                    Console.WriteLine(Math.Round(total, 2) + " " + second);
                }
                if (second == "EUR")
                {
                    total = Math.Round((amount * 2.53405), 2) / 1.95583;
                    Console.WriteLine(Math.Round(total, 2) + " " + second);
                }
            }
        }
   }
}
