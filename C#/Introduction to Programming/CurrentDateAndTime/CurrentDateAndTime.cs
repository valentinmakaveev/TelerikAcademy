/*
Problem 14.* Current Date and Time

Create a console application that prints the current date and time. Find out how in Internet.
*/

using System;

namespace CurrentDateAndTime
{
    class CurrentDateAndTime
    {
        static void Main()
        {
            string timeNow = DateTime.Now.ToString();
            Console.WriteLine("The current date and time now is: {0}", timeNow);
        }
    }
}
