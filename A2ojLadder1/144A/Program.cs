using System;

/*
    Here we find the first index of the maximum number and the last index of the minimum number since we have to move the
    maximum number to the left and the minimum number to the right. Then we just check how many swaps we need to get them to
    their places. In case of the minimum number coming before the maximum number in the array, we have to minus 1 from the 
    total number of swaps since after one gets to its place, the other will move one place closer to its place too.
*/

namespace _144A
{
    class Program
    {
        static void Main(string[] args)
        {
            var arraySize = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ');

            var array = new int[arraySize + 1];

            var maxNumberIndex = 1;
            var minNumberIndex = 1;



            for (int i = 1 ; i <= arraySize; i++)
            {
                array[i] = int.Parse(numbers[i - 1]);

                if(array[i] > array[maxNumberIndex])
                {
                    maxNumberIndex = i;
                }
                if(array[i] <= array[minNumberIndex])
                {
                    minNumberIndex = i;
                }
            }

            var result = 0;

            if(maxNumberIndex < minNumberIndex)
            {
                result = (maxNumberIndex - 1) + (arraySize - minNumberIndex);
            }
            else
            {
                result = (maxNumberIndex - 1) + (arraySize - minNumberIndex) - 1;
            }

            Console.WriteLine(result);
        }
    }
}
