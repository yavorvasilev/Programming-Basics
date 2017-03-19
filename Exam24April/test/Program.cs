using System;
using System.Text;

public static class MyClass
{
    public static void Main()
    {
        var odd = 0;
        var even = 0;
        var money = 0d;
        for (var i = 1; i <= 34; i++)
        {
            
            if (i % 2 == 0)
            {
                odd++;
                money += ((i / 2) * 10) - 1;
            }
            else
            {
                even++;
            }
        }
        Console.WriteLine(odd);
        Console.WriteLine(even);
        Console.WriteLine(money);
    }
}