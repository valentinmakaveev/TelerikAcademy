/*
Problem 10.	Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.

Examples:

n	comments
1	0
3	0 1 1
10	0 1 1 2 3 5 8 13 21 34
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number n:");
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int nextNumber = 1;
            int currentNumber = 0;

            if (n < 0)
            {
                Console.WriteLine("not valid entry");
            }
            else if (n == 0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1)
            {
                Console.WriteLine("0, 1");
            }
            else
            {
                Console.Write("0, 1,");

                for (int i = 2; i < n; i++)
                {
                    currentNumber = number + nextNumber;
                    number = nextNumber;
                    nextNumber = currentNumber;

                 Console.Write(" {0},", currentNumber);
                }
            }

        }
    }
}
