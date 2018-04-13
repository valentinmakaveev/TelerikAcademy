/*
Problem 10.	Odd and Even Product
You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
Examples:

numbers	result
2 1 1 6 3	yes
product = 6	
3 10 4 6 5 1	yes
product = 60	
4 3 2 5 2	no
odd_product = 16	
even_product = 15	
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give n integers (given in a single line, separated by a space).");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');
            int productOdd = 1;
            int productEven = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    productEven *= int.Parse(numbers[i]);
                }
                else
                {
                    productOdd *= int.Parse(numbers[i]);
                }
            }

            if (productEven == productOdd)
            {
                Console.WriteLine("Result: {0}{1}Product = {2}", "yes", Environment.NewLine, productEven);
            }
            else
            {
                Console.WriteLine("Result: {0}{1}even_product = {2}{1}odd_product = {3}", "no", Environment.NewLine, productEven, productOdd);
            }



        }
    }
}
