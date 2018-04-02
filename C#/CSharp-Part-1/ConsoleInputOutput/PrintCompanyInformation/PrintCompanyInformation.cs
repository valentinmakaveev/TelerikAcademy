/*
Problem 2.	Print Company Information
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
Example input:

program	user
Company name:	Telerik Academy
Company address:	31 Al. Malinov, Sofia
Phone number:	+359 888 55 55 555
Fax number:	
Web site:	http://telerikacademy.com/
Manager first name:	Nikolay
Manager last name:	Kostov
Manager age:	25
Manager phone:	+359 2 981 981
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Company address:");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Phone number:");
            string phoneNumber= Console.ReadLine();
            Console.WriteLine("Fax number:");
            string faxNumber = Console.ReadLine();
            Console.WriteLine("Web site:");
            string webSite = Console.ReadLine();
            Console.WriteLine("Manager first name:");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Manager last name:");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Manager age:");
            string managerAge = Console.ReadLine();
            Console.WriteLine("Manager phone:");
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Adress: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, phoneNumber);
        }
    }
}
