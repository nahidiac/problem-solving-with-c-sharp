using System;

namespace _281A
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var capitalizedWord = char.ToUpper(word[0]) + word.Substring(1);

            Console.WriteLine(capitalizedWord);
        }
    }
}
