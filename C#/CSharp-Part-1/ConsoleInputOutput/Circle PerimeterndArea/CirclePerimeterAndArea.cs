/*
Problem 3.	Circle Perimeter and Area
Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
Examples:

r	perimeter	area
2	12.57	12.57
3.5	21.99 38.48
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_PerimeterndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radius:");
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            Console.WriteLine("Perimeter {0: 0.00}", perimeter);
            Console.WriteLine("Area {0: 0.00}", area);

        }
    }
}
