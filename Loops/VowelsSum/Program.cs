﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var length = text.Length;
            var sum = 0;
            for (int i = 0; i < length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;
                }
                //if (text[i] == 'a')
                //{

                //}

            }

            Console.WriteLine(sum);
      
        }
    }
}
