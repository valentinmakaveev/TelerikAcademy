/*
Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
*/
using System;

class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "Valentin";
        string lastName = "Makaveev";
        int age = 28;
        char gender = 'm';
        long personalID = 8306112507;
        long employeeNumber = 27560000;

        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID number: {0}", personalID);
        Console.WriteLine("Unique employee number: {0}", employeeNumber);


    }
}

