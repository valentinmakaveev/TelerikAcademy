/*
 Problem 3.	Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
Examples:

n	Divided by 7 and 5?
3	false
0	true
5	false
7	false
35	true
140	true
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int input = int.Parse(Console.ReadLine());

            if (input % 5 == 0 && input % 7 == 0)
            {
                Console.WriteLine("Divided by 7 and 5? {0}", true);

            }
            else
            {
                Console.WriteLine("Divided by 7 and 5? {0}", false);
            }

        }
    }
}
