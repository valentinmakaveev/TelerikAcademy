/*
 Problem 6.	Print Numbers
Write a program to print the numbers 1, 101 and 1001, each at a separate line.
Name the program correctly.
You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            byte a = 1;
            byte b = 101;
            short c = 1001;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
