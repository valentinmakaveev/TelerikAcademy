﻿/*
Problem 5. Print Your Name

Modify the previous application to print your name.
Ensure you have named the application well (e.g. “PrintMyName”).
You should submit a separate project Visual Studio project holding the PrintMyName class as part of your homework.
*/


using System;

namespace PrintYourName
{
    class PrintYourName
    {
        static void Main()
        {
            Console.WriteLine("Enter my name");
            string name = Console.ReadLine();
            Console.WriteLine("Thanks, My name is {0}",name);
        }
    }
}
