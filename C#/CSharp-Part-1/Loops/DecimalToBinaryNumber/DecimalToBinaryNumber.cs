/*
Problem 14.	Decimal to Binary Number
Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Examples:

decimal	binary
0	0
3	11
43691	1010101010101011
236476736	1110000110000101100101000000
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number:");
            int n = int.Parse(Console.ReadLine());

            List<int> binaryNumber = new List<int>();
            int reminder = 0;

            while (n > 0)
            {
                reminder = n % 2;

                binaryNumber.Add(reminder);
                n = n / 2;
            }

            binaryNumber.Reverse();

            for (int i = 0; i < binaryNumber.Count; i++)
            {
                Console.Write(binaryNumber[i]);
            }
            Console.WriteLine();

        }
    }
}
