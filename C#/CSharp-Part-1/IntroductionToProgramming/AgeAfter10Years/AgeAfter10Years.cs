/*
 Problem 15.*	Age after 10 Years
Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday date in the following format: DD/MM/YYYY");
            string input = Console.ReadLine();
            DateTime birthday = DateTime.ParseExact(input, "dd/MM/yyyy", null);

            DateTime dateTimeNow = DateTime.Now;

            double result = Math.Round(((double)((dateTimeNow - birthday).Days / 365)));

            Console.WriteLine(result);

        }
    }
}
