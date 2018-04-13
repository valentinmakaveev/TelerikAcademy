/*
Problem 8.	Catalan Numbers
In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
Examples:

n	Catalan(n)
0	1
5	42
10	16796
15	9694845
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given n (0 ≤ n ≤ 100)");
            int n = int.Parse(Console.ReadLine());

            BigInteger catalanNumber = 0;
            BigInteger factN = 1;
            BigInteger fact2N = 1;
            BigInteger factNPlus1 = 1;

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }

            for (int i = 1; i <= 2 * n; i++)
            {
                fact2N *= i;
            }

            for (int i = 1; i <= n + 1; i++)
            {
                factNPlus1 *= i;
            }

            catalanNumber = fact2N / (factNPlus1 * factN);
            Console.WriteLine("Catalan(n) {0}", catalanNumber);

        }
    }
}
