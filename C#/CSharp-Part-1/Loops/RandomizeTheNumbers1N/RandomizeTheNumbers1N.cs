/*Problem 12.* Randomize the Numbers 1…N
Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
Examples:

n	randomized numbers 1…n
3	2 1 3
10	3 4 8 2 6 7 9 1 10 5
Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeTheNumbers1N
{
    class RandomizeTheNumbers1N
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer n ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Give a number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Random rnd = new Random();
            numbers = numbers.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
