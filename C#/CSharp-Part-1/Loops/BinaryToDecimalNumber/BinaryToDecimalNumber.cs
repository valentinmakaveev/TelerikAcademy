/*
Problem 13.	Binary to Decimal Number
Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Examples:

binary	decimal
0	0
11	3
1010101010101011	43691
1110000110000101100101000000	236476736
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            string binaryIntegerNumber = "1010101010101011";
            int decimalForm = 0;

            for (int i = 0; i < binaryIntegerNumber.Length; i++)
            {
                if (binaryIntegerNumber[binaryIntegerNumber.Length - i - 1].Equals('1'))
                {
                    decimalForm += (int)Math.Pow(2, i);
                }

            }
            Console.WriteLine("decimal: {0}", decimalForm);
        }
    }
}
