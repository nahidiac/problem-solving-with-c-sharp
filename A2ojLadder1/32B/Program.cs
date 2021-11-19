using System;
using System.Text;

namespace _32B
{
    class Program
    {
        static void Main(string[] args)
        {
            var borzeCode = Console.ReadLine();
            
            var result = new StringBuilder("");

            for (int i = 0; i < borzeCode.Length; i++)
            {
                if(borzeCode[i] == '.')
                {
                    result.Append('0');
                }
                else if(borzeCode[i] == '-')
                {
                    if(i+1 < borzeCode.Length && borzeCode[i+1] == '.')
                    {
                        result.Append('1');
                        i++;
                    }
                    else if (i + 1 < borzeCode.Length && borzeCode[i + 1] == '-')
                    {
                        result.Append('2');
                        i++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
