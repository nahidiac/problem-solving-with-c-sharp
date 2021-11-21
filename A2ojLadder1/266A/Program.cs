using System;

/*
    The task is just to find the occurences where two same-colored stones are neighboring each other. 
*/

namespace _266A
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfStones = int.Parse(Console.ReadLine());
           
            var stones = Console.ReadLine();

            var numberOfDuplicateStones = 0;

            for (int i = 0; i < numberOfStones - 1; i++)
            {
                if(stones[i] == stones[i + 1])
                {
                    numberOfDuplicateStones++;
                }
            }

            Console.WriteLine(numberOfDuplicateStones);
        }
    }
}
