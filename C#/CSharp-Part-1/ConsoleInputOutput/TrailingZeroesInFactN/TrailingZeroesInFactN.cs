﻿/*
Problem 18.* Trailing Zeroes in N!
Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
Examples:

n	trailing zeroes of n!	explaination
10	2	3628800
20	4	2432902008176640000
100000	24999	think why
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TrailingZeroesInFactN
{
    class TrailingZeroesInFactN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give number n");
            int n = int.Parse(Console.ReadLine());

            BigInteger factN = 1;
            int counter = 0;
            bool noReminder = true;

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }

            while (noReminder)
            {
                if (factN % 10 == 0)
                {
                    counter++;
                }
                else
                {
                    noReminder = false;
                }
                factN = factN / 10;
            }

            Console.WriteLine("trailing zeroes of n! {0}", counter);
        }
    }
}
