/*
Problem 1.	Odd or Even Integers
Write an expression that checks if given integer is odd or even.
Examples:

n	Odd?
3	true
2	false
-2	false
-1	true
0	false
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddОrEvenIntegers
{
    class OddОrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Odd?: {0}", false);
            }
            else
            {
                Console.WriteLine("Odd?: {0}", true);
            }
        }
    }
}
