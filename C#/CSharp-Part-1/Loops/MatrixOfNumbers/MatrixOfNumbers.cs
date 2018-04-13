/*
Problem 9.	Matrix of Numbers
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
Examples:

n = 2	matrix		n = 3	matrix		n = 4	matrix
		1 2					1 2 3				1 2 3 4
		2 3					2 3 4				2 3 4 5
							3 4 5				3 4 5 6
												4 5 6 
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer number n (1 ≤ n ≤ 20)");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);

                for (int y = 1; y <= n - 1; y++)
                {

                    Console.Write(i + y);

                }
                Console.WriteLine();
            }
        }
    }
}
