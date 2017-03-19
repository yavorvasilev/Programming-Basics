using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = decimal.Parse(Console.ReadLine());
            var bonusScore = 0m;
            if (score <= 100)
            {
                bonusScore = 5;
            }
            if (score > 100 && score <= 1000)
            {
                bonusScore = (20 * score) / 100;
            }
            if (score > 1000)
            {
                bonusScore = (10 * score) / 100;
            }
            if (score % 2 == 0)
            {
                bonusScore += 1;
            }
            if (score % 10 == 5)
            {
                bonusScore += 2;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(bonusScore + score);
        }
    }
}
