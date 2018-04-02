/*
Problem 4.	Number Comparer
Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
Examples:

a	b	greater
5	6	6
10	5	10
0	0	0
-5	-2	-2
1.5	1.6	1.6
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Give b");
            double b = double.Parse(Console.ReadLine());

            double greater = Math.Max(a, b);
            
            Console.WriteLine("greater: {0}", greater);
        }
    }
}
