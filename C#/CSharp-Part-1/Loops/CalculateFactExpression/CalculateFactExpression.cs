/*
Problem 7.	Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
Examples:

n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10	6	210
52	5	2598960
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CalculateFactExpression
{
    class CalculateFactExpression
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give n and k (1 < k < n < 100");
            Console.WriteLine("Give n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Give k:");
            int k = int.Parse(Console.ReadLine());

            BigInteger factK = 1;
            BigInteger factN = 1;
            BigInteger factNK = 1;
            BigInteger result = 0;


            for (int i = 1; i <= 100; i++)
            {
                if (n >= i)
                {
                    factN *= i;
                }
                if (k >= i)
                {
                    factK *= i;
                }
                if (n - k >= i)
                {
                    factNK *= i;
                }
            }

            result = (factN / (factK * factNK));

            Console.WriteLine("n! / (k! * (n-k)!) {0}", result);


        }
    }
}
