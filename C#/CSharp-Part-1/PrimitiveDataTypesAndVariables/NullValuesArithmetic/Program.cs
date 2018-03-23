/*
Problem 12.	Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
        

            Console.WriteLine("a{0}", a);
            Console.WriteLine("b{0}", b);

            a = a + 5;

            Console.WriteLine("result after adding 5 to null int: {0}",a);


        }
    }
}
