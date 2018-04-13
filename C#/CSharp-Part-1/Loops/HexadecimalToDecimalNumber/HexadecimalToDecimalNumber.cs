/*
Problem 15.	Hexadecimal to Decimal Number
Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Examples:

hexadecimal	decimal
FE	254
1AE3	6883
4ED528CBB4	338583669684
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter exadecimal integer number:");
            string hexadecimal = Console.ReadLine();
    
            ulong result = 0;

            for (int i = 0; i < hexadecimal.Length; i++)
            {
                ulong pow = (ulong)Math.Pow(16, i);
                switch (hexadecimal[hexadecimal.Length - i - 1])
                {
                    case '1':
                        result += 1 * pow;
                        break;
                    case '2':
                        result += 2 * pow;
                        break;
                    case '3':
                        result += 3 * pow;
                        break;
                    case '4':
                        result += 4 * pow;
                        break;
                    case '5':
                        result += 5 * pow;
                        break;
                    case '6':
                        result += 6 * pow;
                        break;
                    case '7':
                        result += 7 * pow;
                        break;
                    case '8':
                        result += 8 * pow;
                        break;
                    case '9':
                        result += 9 * pow;
                        break;
                    case 'A':
                        result += 10 * pow;
                        break;
                    case 'B':
                        result += 11 * pow;
                        break;
                    case 'C':
                        result += 12 * pow;
                        break;
                    case 'D':
                        result += 13 * pow;
                        break;
                    case 'E':
                        result += 14 * pow;
                        break;
                    case 'F':
                        result += 15 * pow;
                        break;
                    default:
                        Console.WriteLine("not real number");
                        break;
                }
                
            }
            Console.WriteLine("Decimal: {0}", result);
        }
    }
}
