using System;

namespace _59A
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            
            var numberOfLowercase = 0; 

            for (int i = 0; i < word.Length; i++)
            {
                if(char.IsLower(word[i]))
                {
                    numberOfLowercase++;
                }
            }

            var numberOfUppercase = word.Length - numberOfLowercase;

            if(numberOfLowercase >= numberOfUppercase)
            {
                Console.WriteLine(word.ToLower());
            }
            else
            {
                Console.WriteLine(word.ToUpper());
            }
        }
    }
}
