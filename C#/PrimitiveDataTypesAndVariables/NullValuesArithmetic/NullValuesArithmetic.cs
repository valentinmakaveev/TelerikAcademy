﻿/*
Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/
using System;

    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = a + 5;
        b = b + 10;
        Console.WriteLine(a);
        Console.WriteLine(b);
        }
    }

