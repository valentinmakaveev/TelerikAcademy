/*
Problem 4.	Print a Deck of 52 Cards
Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
output

2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
…  
K of spades, K of clubs, K of hearts, K of diamonds
A of spades, A of clubs, A of hearts, A of diamonds
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main(string[] args)
        {
            string[] suits = new string[] { "clubs", "diamonds", "hearts", "spades" };
            string[] cardFaces = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string result = "";

            for (int i = 0; i < cardFaces.Length; i++)
            {
                result = "";

                for (int y = 0; y < suits.Length; y++)
                {
                    result += cardFaces[i] + " of " + suits[y] + ", ";
                }
                result = result.Remove(result.Length - 2);
                Console.WriteLine(result);
            }
        }
    }
}
