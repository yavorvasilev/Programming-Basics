using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {

            var w = double.Parse(Console.ReadLine()) * 100;
            var h = double.Parse(Console.ReadLine()) * 100;

            var door = 2 * (160 * 160);
            var corridor = w * 100;
            var tribune = 160 * 120;
            var trainingLab = w * h;
            var numbeOfWorkPlace = trainingLab - corridor;
            Console.WriteLine((numbeOfWorkPlace / (120 * 70)) - 3);
        }
    }
}
