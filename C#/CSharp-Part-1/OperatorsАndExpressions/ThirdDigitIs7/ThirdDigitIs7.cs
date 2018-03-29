/*
Problem 5.	Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7.
Examples:

n	Third digit 7?
5	false
701	true
9703	true
877	false
777877	false
9999799	true
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int n = int.Parse(Console.ReadLine());

            bool thirdDigitIs7 = true;

            n = n / 100;

            if (n % 10 == 7)
            {
                Console.WriteLine("Third digit 7? {0}", thirdDigitIs7);
            }
            else
            {
                thirdDigitIs7 = false;
                Console.WriteLine("Third digit 7? {0}", thirdDigitIs7);
            }


        }
    }
}
