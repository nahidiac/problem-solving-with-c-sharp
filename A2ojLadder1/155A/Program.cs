// See https://aka.ms/new-console-template for more information
using System;

namespace _155A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            var points = new int[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = int.Parse(input[i]);
            }

            var maxPoint = points[0];
            var minPoint = points[0];
            var amazingIncidents = 0;

            for (int i = 1; i < n; i++)
            {
                if(points[i] > maxPoint)
                {
                    maxPoint = points[i];
                    amazingIncidents++;
                }
                else if(points[i] < minPoint)
                {
                    minPoint = points[i];
                    amazingIncidents++;
                }
            }

            Console.WriteLine(amazingIncidents);
        }

    }
}
