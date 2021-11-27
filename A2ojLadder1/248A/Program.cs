// See https://aka.ms/new-console-template for more information

using System;

/*
     Here we need to count the minimum total number of seconds to make all the left doors in the same condition, and 
     all the right doors also in the same condition. Both left and right doors may come to the same condition, no problem.
*/
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] input;

        (int close, int open) left = (0, 0);
        (int close, int open) right = (0, 0);

        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split(' ');

            if(input[0] == "0")
            {
                left.close++;
            }
            else
            {
                left.open++;
            }
            if (input[1] == "0")
            {
                right.close++;
            }
            else
            {
                right.open++;
            }
        }

        var result = Math.Min(left.close, left.open) + Math.Min(right.close, right.open);

        Console.WriteLine(result);
    }
}
