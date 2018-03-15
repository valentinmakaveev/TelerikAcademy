/*
Problem 9.	Print a Sequence
Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
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
            int members = 10;
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
