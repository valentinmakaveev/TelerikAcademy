/*
Problem 5.	Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
Examples:

n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateExpression
{
    class CalculateExpression
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer number n");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Integer number x");
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            double factoriel = 1;
            double pow;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
                pow = Math.Pow(x, i);

                sum += factoriel / pow;
                pow = 0;
            }
            Console.WriteLine("Sum {0: 0.00000}", sum);
        }
    }
}
