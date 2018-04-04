/*
Problem 9. Play with Int, Double and String
Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
Example 1:

program	user
Please choose a type:	
1 --> int	
2 --> double	
3 --> string	3
Please enter a string:	hello
hello*	
Example 2:

program	user
Please choose a type:	
1 --> int	
2 --> double	2
3 --> string	
Please enter a double:	1.5
2.5
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:{0}1 --> int{0}2 --> double{0}3 --> string", Environment.NewLine);
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter an int:");
                    int inputInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(inputInt + 1);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double:");
                    double inputDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(inputDouble + 1);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string:");
                    string inputString = Console.ReadLine();
                    Console.WriteLine(inputString + '*');
                    break;

                default:
                    Console.WriteLine("invalid type");
                    break;
            }
        }
    }
}
