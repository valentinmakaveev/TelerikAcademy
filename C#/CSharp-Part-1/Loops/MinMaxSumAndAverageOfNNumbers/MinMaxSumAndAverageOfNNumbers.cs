/*
Problem 3.	Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
Example 1:

input	output
3 
2 
5 
1	min = 1 
max = 5 
sum = 8 
avg = 2.67
Example 2:

input	output
2 
-1 
4	min = -1 
max = 4 
sum = 3 
avg = 1.50
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n");
            int n = int.Parse(Console.ReadLine());

            int[] inputs = new int[n];
            int min = 0;
            int max = 0;
            int sum = 0;
            double average = 0;

            

            for (int i = 0; i < n; i++)
            {
                inputs[i] = int.Parse(Console.ReadLine());
            }

            min = inputs[0];
            max = inputs[0];
            sum = inputs[0];

            for (int i = 1; i < inputs.Length; i++)
            {
                min = Math.Min(min, inputs[i]);
                max = Math.Max(max, inputs[i]);
                sum += inputs[i];
            }
            average = (double)sum / inputs.Length;


            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:0.00}", average);
        }
    }
}
