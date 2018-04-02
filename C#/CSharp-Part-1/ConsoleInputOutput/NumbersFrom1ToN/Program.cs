﻿/*
Problem 8.	Numbers from 1 to n
Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
Note: You may need to use a for-loop.

Examples:

input	output
3	1
2
3
5	1
2
3
4
5
1	1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number n");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
