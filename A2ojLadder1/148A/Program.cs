// See https://aka.ms/new-console-template for more information

using System;

/*
 * Just check if there's any number which is not divisible by k, l, m, or n. They are not damaged. The rest are damaged.
*/
public class Program
{
    public static void Main(string[] args)
    {
        var k = int.Parse(Console.ReadLine());
        var l = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        var d = int.Parse(Console.ReadLine());

        var damagedDragons = 0;

        for (int i =1; i <= d; i++)
        {
            if(i % k == 0 || i % l == 0 || i % m == 0 || i % n == 0)
            {
                damagedDragons++;
            }
        }

        Console.WriteLine(damagedDragons);
    }
}

