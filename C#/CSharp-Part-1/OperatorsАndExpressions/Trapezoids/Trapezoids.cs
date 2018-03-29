/*
Problem 9.	Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h.
Examples:

a	b	h	area
5	7	12	72
2	1	33	49.5
8.5	4.3	2.7	17.28
100	200	300	45000
0.222	0.333	0.555	0.1540125
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give side a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Give side b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Give height h:");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) * h) / 2;

            Console.WriteLine("Area: {0}", area);
        }
    }
}
