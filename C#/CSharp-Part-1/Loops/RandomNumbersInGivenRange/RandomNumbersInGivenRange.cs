/*
Problem 11.	Random Numbers in Given Range
Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
Examples:

n	min	max	random numbers
5	0	1	1 0 0 1 1
10	10	15	12 14 12 15 10 12 14 13 13 11
Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integers n, min and max (min != max)");
            Console.WriteLine("n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("min");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("max");
            int max = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(rnd.Next(min, max + 1));
            }

        }
    }
}
