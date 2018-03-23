﻿/*
 Problem 2.	Float or Double?
Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            double a = 34.567839023;
            float b = 12.345f;
            double c = 8923.1234567;
            float d = 3456.091f;

            Console.WriteLine("double: {0:F8}", a);
            Console.WriteLine("float: {0:F3}", b);
            Console.WriteLine("double: {0:F7}", c);
            Console.WriteLine("float: {0:F3}", d);
        }
            
    }
}
