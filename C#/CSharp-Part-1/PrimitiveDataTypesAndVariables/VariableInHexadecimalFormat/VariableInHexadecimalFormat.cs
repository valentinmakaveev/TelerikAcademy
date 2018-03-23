/*
 Problem 3.	Variable in Hexadecimal Format
Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
Use Windows Calculator to find its hexadecimal representation.
Print the variable and ensure that the result is 254.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            int a = 254;
            string hexValue = a.ToString("X");
            Console.WriteLine("Hex Value: {0}", hexValue);
        }
    }
}
