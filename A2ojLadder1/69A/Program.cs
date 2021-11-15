using System;

namespace _69A
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfForces = int.Parse(Console.ReadLine());

            var components = new string[3];
            var xComponentSum = 0;
            var yComponentSum = 0;
            var zComponentSum = 0;

            for (int i = 0; i < numberOfForces; i++)
            {
                components = Console.ReadLine().Split(' ');

                xComponentSum += Convert.ToInt32(components[0]);
                yComponentSum += Convert.ToInt32(components[1]);
                zComponentSum += Convert.ToInt32(components[2]);
            }

            if(xComponentSum == 0 && yComponentSum == 0 && zComponentSum == 0)
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
