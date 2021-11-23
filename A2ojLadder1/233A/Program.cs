using System;

/*
    If P[ P[i] ] == i, then it means if a number P[i] is at i-th position, then the index i will be at P[ P[i] ]-th position.
    Simply put, it means if we put 2 in position-1, then in position 2 we have to put 1. So, we'll simply go swapping every two 
    numbers. And it can only happen for even number of permutation size. 
*/

namespace _233A
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfPermutation = int.Parse(Console.ReadLine());

            if(sizeOfPermutation % 2 != 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                for (int i = 1; i < sizeOfPermutation; i += 2)
                {
                    Console.Write($"{i + 1} {i}");

                    if(i < sizeOfPermutation - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
