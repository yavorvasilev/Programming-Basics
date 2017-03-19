using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputValue = double.Parse(Console.ReadLine());
            var metric1 = Console.ReadLine();
            var metric2 = Console.ReadLine();
            var outputValue = 0d;

        
            if (metric1 == "m")
            {
                if (metric2 == "mm")
                {
                    outputValue = inputValue * 1000;
                }
                if (metric2 == "cm")
                {
                    outputValue = inputValue * 100;
                }
                if (metric2 == "mi")
                {
                    outputValue = inputValue * 0.000621371192;
                }
                if (metric2 == "in")
                {
                    outputValue = inputValue * 39.3700787;
                }
                if (metric2 == "km")
                {
                    outputValue = inputValue * 0.001;
                }
                if (metric2 == "ft")
                {
                    outputValue = inputValue * 3.2808399;
                }
                if (metric2 == "yd")
                {
                    outputValue = inputValue * 1.0936133;
                }
               
            }
            if (metric1 == "mm")
            {
                if (metric2 == "m")
                {
                    outputValue = inputValue / 1000;
                }
                if (metric2 == "cm")
                {
                    outputValue = (inputValue / 1000) * 100 ;
                }
                if (metric2 == "mi")
                {
                    outputValue = (inputValue / 1000) * 0.000621371192;
                }
                if (metric2 == "in")
                {
                    outputValue = (inputValue / 1000) * 39.3700787;
                }
                if (metric2 == "km")
                {
                    outputValue = (inputValue / 1000) * 0.001;
                }
                if (metric2 == "ft")
                {
                    outputValue = (inputValue / 1000) * 3.2808399;
                }
                if (metric2 == "yd")
                {
                    outputValue = (inputValue / 1000) * 1.0936133;
                }
               
            }
            if (metric1 == "cm")
            {
                if (metric2 == "mm")
                {
                    outputValue = (inputValue / 100) * 1000;
                }
                if (metric2 == "m")
                {
                    outputValue = (inputValue / 100);
                }
                if (metric2 == "mi")
                {
                    outputValue = (inputValue / 100) * 0.000621371192;
                }
                if (metric2 == "in")
                {
                    outputValue = (inputValue / 100) * 39.3700787;
                }
                if (metric2 == "km")
                {
                    outputValue = (inputValue / 100) * 0.001;
                }
                if (metric2 == "ft")
                {
                    outputValue = (inputValue / 100) * 3.2808399;
                }
                if (metric2 == "yd")
                {
                    outputValue = (inputValue / 100) * 1.0936133;
                }
                
            }
            if (metric1 == "mi")
            {
                if (metric2 == "mm")
                {
                    outputValue = (inputValue / 0.000621371192) * 1000;
                }
                if (metric2 == "cm")
                {
                    outputValue = (inputValue / 0.000621371192) * 100;
                }
                if (metric2 == "m")           
                {
                    outputValue = inputValue / 0.000621371192;
                }
                if (metric2 == "in")
                {
                    outputValue = (inputValue / 0.000621371192) * 39.3700787;
                }
                if (metric2 == "km")
                {
                    outputValue = (inputValue / 0.000621371192) * 0.001;
                }
                if (metric2 == "ft")
                {
                    outputValue = (inputValue / 0.000621371192) * 3.2808399;
                }
                if (metric2 == "yd")
                {
                    outputValue = (inputValue / 0.000621371192) * 1.0936133;
                }
               
            }
            if (metric1 == "in")
            {
                if (metric2 == "mm")
                {
                    outputValue = (inputValue / 39.3700787) * 1000;
                }
                if (metric2 == "cm")
                {
                    outputValue = (inputValue / 39.3700787) * 100;
                }
                if (metric2 == "mi")
                {
                    outputValue = (inputValue / 39.3700787) * 0.000621371192;
                }
                if (metric2 == "m")
                {
                    outputValue = inputValue / 39.3700787;
                }
                if (metric2 == "km")
                {
                    outputValue = (inputValue / 39.3700787) * 0.001;
                }
                if (metric2 == "ft")
                {
                    outputValue = (inputValue / 39.3700787) * 3.2808399;
                }
                if (metric2 == "yd")
                {
                    outputValue = (inputValue / 39.3700787) * 1.0936133;
                }
               
            }
            if (metric1 == "km")
            {
                if (metric2 == "mm")
                {
                    outputValue = (inputValue / 0.001) * 1000;
                }
                if (metric2 == "cm")
                {
                    outputValue = (inputValue / 0.001) * 100;
                }
                if (metric2 == "mi")
                {
                    outputValue = (inputValue / 0.001) * 0.000621371192;
                }
                if (metric2 == "in")
                {
                    outputValue = (inputValue / 0.001) * 39.3700787;
                }
                if (metric2 == "m")
                {
                    outputValue = inputValue / 0.001;
                }
                if (metric2 == "ft")
                {
                    outputValue = (inputValue / 0.001) * 3.2808399;
                }
                if (metric2 == "yd")
                {
                    outputValue = (inputValue / 0.001) * 1.0936133;
                }
               
            }
            if (metric1 == "ft")
            {
                if (metric2 == "mm")
                {
                    outputValue = (inputValue / 3.2808399) * 1000;
                }
                if (metric2 == "cm")
                {
                    outputValue = (inputValue / 3.2808399) * 100;
                }
                if (metric2 == "mi")
                {
                    outputValue = (inputValue / 3.2808399) * 0.000621371192;
                }
                if (metric2 == "in")
                {
                    outputValue = (inputValue / 3.2808399) * 39.3700787;
                }
                if (metric2 == "km")
                {
                    outputValue = (inputValue / 3.2808399) * 0.001;
                }
                if (metric2 == "m")
                {
                    outputValue = inputValue / 3.2808399;
                }
                if (metric2 == "yd")
                {
                    outputValue = (inputValue / 3.2808399) * 1.0936133;
                }
               
            }
            if (metric1 == "yd")
            {
                if (metric2 == "mm")
                {
                    outputValue = (inputValue / 1.0936133) * 1000;
                }
                if (metric2 == "cm")
                {
                    outputValue = (inputValue / 1.0936133) * 100;
                }
                if (metric2 == "mi")
                {
                    outputValue = (inputValue / 1.0936133) * 0.000621371192;
                }
                if (metric2 == "in")
                {
                    outputValue = (inputValue / 1.0936133) * 39.3700787;
                }
                if (metric2 == "km")
                {
                    outputValue = (inputValue / 1.0936133) * 0.001;
                }
                if (metric2 == "ft")
                {
                    outputValue = (inputValue / 1.0936133) * 3.2808399;
                }
                if (metric2 == "m")
                {
                    outputValue = inputValue / 1.0936133;
                }           
            }
            if (metric1 == metric2)
            {
                Console.WriteLine(inputValue + " " + metric2);
            }
            else
            {
                Console.WriteLine(outputValue + " " + metric2);
            }
        }
    }   
}
