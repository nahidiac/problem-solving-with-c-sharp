using System;
using System.Text; 

namespace _61A
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();
            var length = firstNumber.Length;
            var result = new StringBuilder(""); 

            for (int i = 0; i < length; i++)
            {
                if(firstNumber[i] == secondNumber[i])
                {
                    result.Append("0"); 
                }
                else
                {
                    result.Append("1");
                }
            }

            Console.WriteLine(result);
        }
    }
}
