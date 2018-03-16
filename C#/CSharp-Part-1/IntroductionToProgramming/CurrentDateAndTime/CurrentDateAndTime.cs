/*
Problem 14.*	Current Date and Time
Create a console application that prints the current date and time. Find out how in Internet.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentDateAndTime
{
    class CurrentDateAndTime
    {
        static void Main(string[] args)
        {
            DateTime dateTimeNow = DateTime.Now;
            Console.WriteLine("Current date and time: {0}", dateTimeNow);
        }
    }
}
