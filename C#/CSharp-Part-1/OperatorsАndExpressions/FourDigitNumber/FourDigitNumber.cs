/*
Problem 6.	Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four digit number in format abcd (e.g. 2011): ");
            int abcd = int.Parse(Console.ReadLine());
            int d = abcd % 10;
            int c = (abcd / 10) % 10;
            int b = (abcd / 100) % 10;
            int a = (abcd / 1000) % 10;
            int sum = a + b + c + d;
            string revOrder = ""+ d + c + b + a;
            string lastOnFirstPosit = "" + d + a + b + c;
            string exchangeSecondThirdDigit = "" + a + c + b + d;

            Console.WriteLine("Sum of digits {0}", sum);
            Console.WriteLine("Reversed {0}", revOrder);
            Console.WriteLine("Last digit in front {0}", lastOnFirstPosit);
            Console.WriteLine("Second and third digits exchanged {0}", exchangeSecondThirdDigit);

        }
    }
}
