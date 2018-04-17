/*
 Problem 4. Maximal sequence
Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of number separated by comma and space");
            string input = Console.ReadLine();

            input = input.Replace(" ", "");
            List<int> numbers = input.Split(',').Select(Int32.Parse).ToList();

            string maximalSequence = "";
            string currentSequence = "" + numbers[0];
            int counter = 0;
            int maxCounter = 0;
      

            for (int i = 1; i < numbers.Count; i++)
            {
               
                if (numbers[i-1] == numbers[i])
                {
                    currentSequence += " " + numbers[i];
                    counter++;
                }
                else
                {
                    if (maxCounter< counter)
                    {
                        maxCounter = counter;
                        maximalSequence = currentSequence;
                    }
                    currentSequence = numbers[i] + "";
                    counter = 0;
                }

            }
            Console.WriteLine(maximalSequence);
            


        }
    }
}
