/*
Problem 5.	Formatting Numbers
Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
Examples:

a	b	c	result
254	11.6	0.5	`FE
499	-0.5559	10000	`1F3
0	3	-0.1234	`0
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give integer a (0 <= a <= 500)");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give floating-point b");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Please give floating-point c");
            float c = float.Parse(Console.ReadLine());

            string hexValue = a.ToString("X");
            Console.Write("{0,-10}", hexValue);

            string binary = Convert.ToString(a, 2);
            Console.Write("{0,-10}", binary);

            //b printed with 2 digits after the decimal point, right aligned
            Console.Write("{0,10:0.00}", b);

            //c printed with 3 digits after the decimal point, left aligned.
            Console.Write("{0,-10:0.000}", c);

        }
    }
}
