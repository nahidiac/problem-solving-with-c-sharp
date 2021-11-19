using System;

/*
    Simply keep increasing the number of year and check if it's beautiful. 
*/

namespace _271A
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine()); 

            while(!IsBeautiful(++year))
            {
            }

            Console.WriteLine(year);
        }

        static bool IsBeautiful(int year)
        {
            var arr = year.ToString().ToCharArray();
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i+1])
                    return false;
            }

            return true;
        }
    }
}
