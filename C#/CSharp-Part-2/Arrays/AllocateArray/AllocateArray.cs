/*
Problem 1. Allocate array
Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int before = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                before = numbers[i];
                numbers[i] = numbers[i] * 5;
                Console.WriteLine("before: numbers[{0}] = {1}{2}now: numbers[{0}] = {3}{2}", i, before, Environment.NewLine, numbers[i]);
            }
        }
    }
}
