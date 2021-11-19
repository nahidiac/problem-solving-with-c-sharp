using System;
using System.Text;

/*
    The idea is just to simulate the process. Run loop equal to the value of time. For each second loop through the string and 
    make the changes. 
    N.B: Complexity n*t. I think it can be solved in O(n). 
*/
namespace _266B
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var queueLength = int.Parse(input[0]);
            var totalTime = int.Parse(input[1]);

            var queue = Console.ReadLine();
            var result = new StringBuilder("");

            for (int j = 0; j < totalTime; j++)
            {
                for (int i = 0; i < queueLength; i++)
                {
                    if (queue[i] == 'G')
                    {
                        result.Append('G');
                    }
                    else if(queue[i] == 'B')
                    {
                        if (i + 1 < queueLength && queue[i + 1] != 'G')
                        {
                            result.Append('B');
                        }
                        else if (i + 1 < queueLength)
                        {
                            result.Append('G');
                            result.Append('B');
                            i++;
                        }
                        else
                        {
                            result.Append('B');
                        }
                    }
                }

                queue = result.ToString();
                result.Clear();
            }

            Console.WriteLine(queue);
        }
    }
}
