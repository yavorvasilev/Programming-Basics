using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            char l1 = 'a';
            char l2 = 'a';

            for (int i1 = 1; i1 <= n; i1++)
            {
                for (int i2 = 1; i2 <= n; i2++)
                {
                    for (int i3 = 1; i3 <= l; i3++)
                    {
                        for (int i4 = 1; i4 <= l; i4++)
                        {
                            for (int i5 = Math.Max(i1, i2) + 1; i5 <= n; i5++)
                            {
                                switch (i3)
                                {
                                    case 1: l1 = 'a';
                                        break;
                                    case 2:
                                        l1 = 'b';
                                        break;
                                    case 3:
                                        l1 = 'c';
                                        break;
                                    case 4:
                                        l1 = 'd';
                                        break;
                                    case 5:
                                        l1 = 'e';
                                        break;
                                    case 6:
                                        l1 = 'f';
                                        break;
                                    case 7:
                                        l1 = 'g';
                                        break;
                                    case 8:
                                        l1 = 'h';
                                        break;
                                    case 9:
                                        l1 = 'i';
                                        break;
                                }
                                switch (i4)
                                {
                                    case 1:
                                        l2 = 'a';
                                        break;
                                    case 2:
                                        l2 = 'b';
                                        break;
                                    case 3:
                                        l2 = 'c';
                                        break;
                                    case 4:
                                        l2 = 'd';
                                        break;
                                    case 5:
                                        l2 = 'e';
                                        break;
                                    case 6:
                                        l2 = 'f';
                                        break;
                                    case 7:
                                        l2 = 'g';
                                        break;
                                    case 8:
                                        l2 = 'h';
                                        break;
                                    case 9:
                                        l2 = 'i';
                                        break;
                                }


                                Console.Write("{0}{1}{2}{3}{4} ", i1, i2, l1, l2, i5);
                               
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
