/*
Problem 11.* Number as Words
Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
Examples:

| numbers | number as words | |---------|-------------------------------|- | 0 | Zero | | 9 | Nine | | 10 | Ten | | 12 | Twelve | | 19 | Nineteen | | 25 | Twenty five | | 98 | Ninety eight | | 98 | Ninety eight | | 273 | Two hundred and seventy three | | 400 | Four hundred | | 501 | Five hundred and one | | 617 | Six hundred and seventeen | | 711 | Seven hundred and eleven | | 999 | Nine hundred and ninety nine |
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsWords
{
    class NumberAsWords
    {
        static void Digit(int digit)
        {
            switch (digit)
            {
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;
                case 10:
                    Console.Write("ten");
                    break;
                case 11:
                    Console.Write("eleven");
                    break;
                case 12:
                    Console.Write("twelve");
                    break;
                case 13:
                    Console.Write("thirteen");
                    break;
                case 14:
                    Console.Write("fourteen");
                    break;
                case 15:
                    Console.Write("fifteen");
                    break;
                case 16:
                    Console.Write("sixteen");
                    break;
                case 17:
                    Console.Write("seventeen");
                    break;
                case 18:
                    Console.Write("eighteen");
                    break;
                case 19:
                    Console.Write("nineteen");
                    break;
                default:
                    Console.Write("not correct input");
                    break;
            }
        }
        static void DigitTens(int digitTens)
        {
            switch (digitTens)
            {
                case 2:
                    Console.Write("twenty");
                    break;
                case 3:
                    Console.Write("thirty");
                    break;
                case 4:
                    Console.Write("fourty");
                    break;
                case 5:
                    Console.Write("fifty");
                    break;
                case 6:
                    Console.Write("sixty");
                    break;
                case 7:
                    Console.Write("seventy");
                    break;
                case 8:
                    Console.Write("eighty");
                    break;
                case 9:
                    Console.Write("ninety");
                    break;
                default:
                    Console.Write("not correct input");
                    break;
            }
        }
        static void Main(string[] args)
        {
            int digit = 0;
            int digitTens = 0;
            int hundrets = 0;

            Console.WriteLine(" Enter a number in the range [0…999] ");
            int input = int.Parse(Console.ReadLine());

            if (input <= 19)
            {
                Digit(input);

            }
            else if (input > 19 && input < 100)
            {
                digit = input % 10;
                digitTens = input / 10;

                DigitTens(digitTens);
                Console.Write(" ");
                if (digit > 0)
                {
                    Digit(digit);
                }
                Console.WriteLine();

            }
            else if (input >= 100 && input < 999)
            {
                digit = input % 10;
                digitTens = input / 10;
                hundrets = digitTens / 10;
                digitTens = digitTens % 10;

                
                if (hundrets > 0)
                {
                    Digit(hundrets);
                }
                Console.Write(" hundret ");
               
                if (digitTens > 0)
                {
                    DigitTens(digitTens);
                }
                Console.Write(" ");
                if (digit > 0)
                {
                    Digit(digit);
                }
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Not valid entry");
            }
        }
        
    }
}


