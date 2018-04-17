/*
Problem 2. Compare arrays
Write a program that reads two integer arrays from the console and compares them element by element.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give size of the arrays");
            int sizeArrays = int.Parse(Console.ReadLine());

            int[] firstArray = new int[sizeArrays];
            int[] secondArray = new int[sizeArrays];

            Console.WriteLine("Give {0} values for 1 array:", sizeArrays);

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("Value {0}:", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Give {0} values for 2 array:", sizeArrays);

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine("Value {0}:", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            //compare elements

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int y = 0; y < secondArray.Length; y++)
                {
                    if (firstArray[i] == secondArray[y])
                    {
                        Console.WriteLine("firstArray[{0}] == secondArray[{1}]", i, y);
                    }
                    else if (firstArray[i] > secondArray[y])
                    {
                        Console.WriteLine("firstArray[{0}] > secondArray[{1}]", i, y);
                    }
                    else if (firstArray[i] < secondArray[y])
                    {
                        Console.WriteLine("firstArray[{0}] < secondArray[{1}]", i, y);
                    }
                }
            }
        }
    }
}
