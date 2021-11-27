// See https://aka.ms/new-console-template for more information

using System;
/*
 * If there are n drinks, then each drink has equal, that is, 1/n amout of it in the cocktail.
 * So each portion has (percentage/n)% 
 * If we add this for each of the portions, we get our result.
 */
public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        
        var input = Console.ReadLine().Split(' ');

        double result = 0.0;

        for (int i = 0; i < n; i++)
        {
            result += double.Parse(input[i]) / n;
        }

        Console.WriteLine(result.ToString("0.000000"));
    }
}
