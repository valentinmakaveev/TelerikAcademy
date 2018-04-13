/*
Problem 16.	Decimal to Hexadecimal Number
Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Examples:

decimal	hexadecimal
254	FE
6883	1AE3
338583669684	4ED528CBB4
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number");
            long n = long.Parse(Console.ReadLine());
            long reminder = 0;
            List<long> reminders = new List<long>();

            while (n > 0)
            {
                reminder = n % 16;
                reminders.Add(reminder);
                n = n / 16;

            }
            for (int i = 0; i < reminders.Count; i++)
            {
                switch (reminders[reminders.Count-i - 1])
                {
                    case 10:
                        Console.Write('A');
                        break;
                    case 11:
                        Console.Write('B');
                        break;
                    case 12:
                        Console.Write('C');
                        break;
                    case 13:
                        Console.Write('D');
                        break;
                    case 14:
                        Console.Write('E');
                        break;
                    case 15:
                        Console.Write('F');
                        break;
                    default:
                        Console.Write(reminders[reminders.Count - i - 1]);
                        break;
                        
                }
          
            }
            Console.WriteLine();

        }
    }
}
