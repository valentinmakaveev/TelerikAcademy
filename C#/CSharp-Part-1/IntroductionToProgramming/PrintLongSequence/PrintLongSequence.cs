/*
 Problem 16.*	Print Long Sequence
Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
You might need to learn how to use loops in C# (search in Internet).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main(string[] args)
        {
            int members = 1000;
            int firstMember = 2;

            for (int n = firstMember; n < members + firstMember; n++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine(-n);
                }
            }
        }
    }
}
