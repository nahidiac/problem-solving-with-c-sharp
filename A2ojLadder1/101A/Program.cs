using System;

namespace _101A
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var totalLuckyDigits = 0;

            foreach(var digit in number)
            {

                if(digit == '4' || digit == '7')
                {
                    totalLuckyDigits++;
                }
            }

            if(totalLuckyDigits == 4 || totalLuckyDigits == 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
