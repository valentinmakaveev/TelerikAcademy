/*
 Problem 19.** Spiral Matrix
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
Examples:

n = 2	matrix		n = 3	matrix		n = 4	matrix
		1 2					1 2 3				1  2  3  4
		4 3					8 9 4				12 13 14 5
							7 6 5				11 16 15 6
												10 9  8  7
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer number n (1 ≤ n ≤ 20):");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int length = n * n;
            int row = 0;
            int col = 0;
            string direction = "right";

            for (int i = 1; i <= length; i++)
            {


                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    col--;
                    row++;
                    direction = "down";
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    row--;
                    col--;
                    direction = "left";
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    row--;
                    col++;
                    direction = "up";

                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    row++;
                    col++;
                    direction = "right";
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }



            }

            //drow the matrix

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,6}", matrix[r, c]);
                }
                Console.WriteLine();
            }

        }
    }
}
