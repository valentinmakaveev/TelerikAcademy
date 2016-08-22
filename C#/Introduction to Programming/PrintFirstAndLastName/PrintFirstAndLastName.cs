/*
Problem 7. Print First and Last Name

Create console application that prints your first and last name, each at a separate line.
*/


using System;


namespace PrintFirstAndLastName
{
    class PrintFirstAndLastName
    {
        static void Main()
        {
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your second name");
            string secondName = Console.ReadLine();
           
            Console.WriteLine("My first name is: {0}{1}My second name is: {2}", firstName, Environment.NewLine, secondName);
        }
    }
}
