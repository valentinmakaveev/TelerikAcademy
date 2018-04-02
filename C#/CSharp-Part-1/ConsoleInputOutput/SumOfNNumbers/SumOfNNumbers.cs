/*
Problem 9.	Sum of n Numbers
Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
Examples:

numbers	sum
3	90
20	
60	
10	
5	6.5
2	
-1	
-0.5	
4	
2	
1	1
1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n");
            double n = double.Parse(Console.ReadLine());

            int length = (int)Math.Round(n);
            double sum = 0;
            for (int i = 0; i < length; i++)
            {
                n = double.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine("Sum: {0}", sum);

        }
    }
}
