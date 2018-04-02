/*
Problem 1.	Sum of 3 Numbers
Write a program that reads 3 real numbers from the console and prints their sum.
Examples:

a	b	c	sum
3	4	11	18
-2	0	3	1
5.5	4.5	20.1	30.1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter c");
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;

            Console.WriteLine("Sum: {0}", sum);


        }
    }
}
