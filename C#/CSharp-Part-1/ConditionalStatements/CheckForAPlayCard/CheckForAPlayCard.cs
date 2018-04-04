/*
Problem 3. Check for a Play Card
Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
character	Valid card sign?
5	yes
1	no
Q	yes
q	no
P	no
10	yes
500	no
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter card string");
            string card = Console.ReadLine();

            switch (card)
            {
                case "1":
                    Console.WriteLine("Valid card sign? {0}","Yes");
                    break;
                case "2":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "3":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "4":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "5":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "6":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "7":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "8":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "9":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "10":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "J":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "Q":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "K":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                case "A":
                    Console.WriteLine("Valid card sign? {0}", "Yes");
                    break;
                default:
                    Console.WriteLine("Valid card sign? {0}", "No");
                    break;
            }
        }
    }
}
