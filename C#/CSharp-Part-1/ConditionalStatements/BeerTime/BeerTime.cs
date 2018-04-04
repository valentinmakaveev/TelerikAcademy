﻿/*
Problem 10.* Beer Time
A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
Examples:

time	result
1:00 PM	beer time
4:30 PM	beer time
10:57 PM	beer time
8:30 AM	non-beer time
02:59 AM	beer time
03:00 AM	non-beer time
03:26 AM	non-beer time
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)");
            string input = Console.ReadLine();

            string format = "hh:mm tt";
            DateTime beerTimeAfter = DateTime.Parse("01:00 pm");
            DateTime beerTimeBefore = DateTime.Parse("03:00 am");
            DateTime date;

            if (DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out date))
            {
                int compareValue = DateTime.Compare(date, beerTimeBefore);
                int compareValue1 = DateTime.Compare(date, beerTimeAfter);

                if (compareValue <= 0 || compareValue1 >= 0)
                {
                    Console.WriteLine("Beer Time");
                }
                else
                {
                    Console.WriteLine("xaxaxa no beer for you");
                }

            }
            else
            {
                Console.WriteLine("invalid time");
            }

        }
    }
}
