﻿/*
Problem 3. Variable in Hexadecimal Format

Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
Use Windows Calculator to find its hexadecimal representation.
Print the variable and ensure that the result is 254.
*/
using System;


namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            int number = 254;
            string hexValue = number.ToString("X");
            Console.WriteLine(hexValue);
        }
    }
}
