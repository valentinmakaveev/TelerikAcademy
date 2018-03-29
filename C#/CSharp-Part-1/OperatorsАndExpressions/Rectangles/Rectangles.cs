/*
Problem 4.	Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:

width	height	perimeter	area
3	4	14	12
2.5	3	11	7.5
5	5	20	25
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Height");
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width + height) * 2;
            double area = width * height;
            Console.WriteLine("Perimeter: {0} Area: {1}", perimeter,area);

        }
    }
}
