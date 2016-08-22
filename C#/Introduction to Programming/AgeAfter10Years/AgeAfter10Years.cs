/*
Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

using System;
using System.Text.RegularExpressions;


namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
          
            Console.WriteLine("Please write your birthday date (days:month:year)");
            string input = Console.ReadLine();

            char[] delimeters = { '.', '/', ';' };
                        
            int[] birthNumbers = Array.ConvertAll(input.Split(delimeters), int.Parse);

            string today = DateTime.Today.ToString("dd/MM/yyyy");
                        
            int[] todayNumbers = Array.ConvertAll(today.Split(delimeters), int.Parse);


            if (birthNumbers[1]> todayNumbers[1])
            {
                Console.WriteLine(todayNumbers[2]- birthNumbers[2] -1 );
            }
            else if (birthNumbers[1] < todayNumbers[1])
            {
                Console.WriteLine(todayNumbers[2] - birthNumbers[2] );
            }
            else if (birthNumbers[1] == todayNumbers[1])
            {
                if (birthNumbers[0] == todayNumbers[0])
                {
                    Console.WriteLine("today you have a birthday and you are");
                    Console.WriteLine(todayNumbers[2] - birthNumbers[2]);
                }
                else
                {
                    Console.WriteLine("This month will be your birthday, you are now");
                    Console.WriteLine(todayNumbers[2] - birthNumbers[2] -1);
                }
            }


        }
    }
}
