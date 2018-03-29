/*
Problem 8.	Prime Number Check
Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
Examples:

n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give positive integer number n (n ≤ 100)");
            int input = int.Parse(Console.ReadLine());
            int primeCount = 0;
            bool isPrime = false;

            if (input <= 1)
            {
                Console.WriteLine("Prime? {0}", isPrime);
            }
            else
            {
                for (int i = 2; i <= input; i++)
                {
                    if (input % i == 0)
                    {
                        primeCount++;
                    }
                }

                if (primeCount < 2)
                {
                    isPrime = true;
                }

                Console.WriteLine("Prime? {0}", isPrime);
            }

        }
    }
}
