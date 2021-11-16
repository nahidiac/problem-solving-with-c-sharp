using System;

/*
    Here swapping of rows or columns is simply equivalent to moving the 1 along the row or column (but not along the diagonals!).
    So I just counted both the distances: row-wise and column-wise from position (3,3) and added the distances.
    Since every unit of distance takes one move, the total distance will give the total number of moves.
*/

namespace _263A
{
    class Program
    {
        static void Main(string[] args)
        {
            var row = new string[5];

            (int, int) position = (0,0);
            var positionFound = false;

            for (int i = 1; i <= 5; i++)
            {
                row = Console.ReadLine().Split(' ');

                if(!positionFound)
                {
                    for (int j = 0; j < row.Length; j++)
                    {
                        if (int.Parse(row[j]) == 1)
                        {
                            positionFound = true;
                            position = (i, j + 1);
                            break;
                        }
                    }
                }
            }

            var movesNeeded = Math.Abs(3 - position.Item1) + Math.Abs(3 - position.Item2);

            Console.WriteLine(movesNeeded);
        }
    }
}
