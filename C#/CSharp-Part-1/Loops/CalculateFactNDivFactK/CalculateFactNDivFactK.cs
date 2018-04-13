/*
Problem 6.	Calculate N! / K!
Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
Examples:

n	k	n! / k!
5	2	60
6	5	6
8	3	6720
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace CalculateFactNDivFactK
{
    class CalculateFactNDivFactK
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give n and k (1 < k < n < 100");
            Console.WriteLine("Give n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Give k:");
            int k = int.Parse(Console.ReadLine());

            BigInteger fakN = 1;
            BigInteger fakK = 1;
            BigInteger result = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i <= n)
                {
                    fakN *= i;
                }
                if (i <= k)
                {
                    fakK *= i;
                }
            }

            result = fakN / fakK;

            Console.WriteLine(result);
        }
    }
}
