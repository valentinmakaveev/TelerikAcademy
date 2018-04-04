/*
Problem 6. The Biggest of Five Numbers
Write a program that finds the biggest of five numbers by using only five if statements.
Examples:

a	b	c	d	e	biggest
5	2	2	4	1	5
-2	-22	1	0	0	1
-2	4	3	2	0	4
0	-2.5	0	5	5	5
-3	-0.5	-1.1	-2	-0.1	-0.1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter c");
            double c = double.Parse(Console.ReadLine());

            double biggest = Math.Max(a, b);
            biggest = Math.Max(biggest,c);

            Console.WriteLine("biggest {0}", biggest);
        }
    }
}
