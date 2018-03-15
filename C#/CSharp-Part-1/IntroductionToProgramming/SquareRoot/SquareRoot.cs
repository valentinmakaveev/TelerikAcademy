/*
 Problem 8.	Square Root
Create a console application that calculates and prints the square root of the number 12345.
Find in Internet “how to calculate square root in C#”.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            double number = 12345;
            double result = Math.Sqrt(number);
            Console.WriteLine(result);
        }
    }
}
