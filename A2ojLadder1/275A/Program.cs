using System;

/*
    If a light is on at the beginning, then toggling it odd number of  times will turn it off, otherwise it will be on.
    So we just loop through the number of toggles, and for each of the lights, we also add the number of toggles to its
    side-adjacents also. Finally we loop through the grid, and based on the total number of toggles for each of the lights
    we can come to conclusion as to which ones are on, and which one are off.
*/

namespace _275A
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new int[3, 3];
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = 0;
                }
            }

            string[] line;
            int element = 0; 

            for (int i = 0; i < 3; i++)
            {
                line = (Console.ReadLine()).Split(' ');

                for (int j = 0; j < 3; j++)
                {
                    element = int.Parse(line[j]);

                    grid[i, j] += element; 

                    if(i + 1 < 3) grid[i+1, j] += element;
                    if (j + 1 < 3) grid[i, j+1] += element;
                    if (i - 1 >= 0) grid[i-1, j] += element;
                    if (j - 1 >= 0) grid[i, j-1] += element;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(grid[i, j] % 2 == 0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
