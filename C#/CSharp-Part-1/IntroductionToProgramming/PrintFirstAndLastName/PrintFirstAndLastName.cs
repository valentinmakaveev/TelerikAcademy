/*
 Problem 7.	Print First and Last Name
Create console application that prints your first and last name, each at a separate line.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirstAndLastName
{
    class PrintFirstAndLastName
    {
        static void Main(string[] args)
        {
            string firstName = "Valentin";
            string lastName = "Makaveev";

            Console.WriteLine("First name: {0}{1}Last name: {2}", firstName, Environment.NewLine, lastName);
        }
    }
}
