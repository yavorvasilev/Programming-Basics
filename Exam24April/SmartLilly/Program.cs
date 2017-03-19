using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());
            var washingMachinePrice = double.Parse(Console.ReadLine());
            var toysPrice = double.Parse(Console.ReadLine());
            var overallMoney = 0d;
            var moneyFromToys = 0d;
            var money = 0d;
            var toys = 0;

            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    money += ((i / 2) * 10) - 1;
                }
                else
                {
                    toys += 1;
                }
            }
            moneyFromToys = toys * toysPrice;
            overallMoney = moneyFromToys + money;

            if (overallMoney - washingMachinePrice >= 0)
            {
                Console.WriteLine("Yes! {0:0.00}", overallMoney - washingMachinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:0.00}", washingMachinePrice - overallMoney);
            }

        }
    }
}
