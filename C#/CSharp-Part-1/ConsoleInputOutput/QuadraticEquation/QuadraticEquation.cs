/*
Problem 6.	Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Examples:

a	b	c	roots
2	5	-3	x1=-3; x2=0.5
-1	3	0	x1=3; x2=0
-0.5	4	-8	x1=x2=4
5	2	8	no real roots
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coefficients a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("coefficients b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("coefficients c");
            double c = double.Parse(Console.ReadLine());
            //discriminant
            double d = b * b - 4 * a * c;
            double x;
            double x1;
            double x2;

            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (d == 0)
            {
                x = -(b / 2 * a);
                Console.WriteLine("x = {0}", x);
            }
            else
            {
                x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine("x2 = {0}", x2);
            }





        }
    }
}
