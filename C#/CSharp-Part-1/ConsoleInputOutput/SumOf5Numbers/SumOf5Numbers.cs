/*
Problem 7.	Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
Examples:

numbers	sum
1 2 3 4 5	15
10 10 10 10 10	50
1.5 3.14 8.2 -1 0	11.84
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers (given in a single line, separated by a space)");
            string numbers = Console.ReadLine();
            double sum =0;

            string [] numbersArray = numbers.Split(' ');

            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum += Convert.ToDouble(numbersArray[i]);
            }

            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
