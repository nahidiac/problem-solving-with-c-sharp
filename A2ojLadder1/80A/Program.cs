using System;

namespace _80A
{
    class Program
    {
        static bool[] isPrime; 
        static void Main(string[] args)
        {
            sieve();

            var input = (Console.ReadLine()).Split(' ');
            var number1 = int.Parse(input[0]);
            var number2 = int.Parse(input[1]);

            if(!isPrime[number2])
            {
                Console.WriteLine("NO");
            }
            else
            {
                var nextPrime = 0;

                for (int i = number1 + 1; i <= 50; i++)
                {
                    if (isPrime[i])
                    {
                        nextPrime = i;
                        break;
                    }
                }

                if (number2 == nextPrime)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            
        }

        static void sieve()
        {
            isPrime = new bool[51];

            for(int i = 2; i <= 50; i++)
            {
                isPrime[i] = true;
            }

            for(int i = 4; i <= 50; i += 2)
            {
                isPrime[i] = false; 
            }

            for(int i = 3; i*i <= 50; i += 2)
            {
                for(int j = i*i; j <= 50; j += i+i)
                {
                    isPrime[j] = false;
                }
            }
        }
    }
}
