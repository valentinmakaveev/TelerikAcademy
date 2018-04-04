﻿/*
Problem 4. Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
Examples:

a	b	c	result
5	2	2	+
-2	-2	1	+
-2	4	3	-
0	-2.5	4	0
-1	-0.5	-5.1	-
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fist number:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Second number:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Third number:");
            double c = double.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Result: {0}", '+');
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Result: {0}", '-');
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("Result: {0}", '-');
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("Result: {0}", '-');
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("Result: {0}", '+');
            }
            else if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("Result: {0}", '+');
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("Result: {0}", '-');
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Result: {0}", '0');
            }
        }
    }
}
