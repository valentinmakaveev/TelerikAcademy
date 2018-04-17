/*
Problem 3. Compare char arrays
Write a program that compares two char arrays lexicographically (letter by letter).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give size of the arrays");
            int sizeArrays = int.Parse(Console.ReadLine());

            char[] firstArray = new char[sizeArrays];
            char[] secondArray = new char[sizeArrays];
            string input = "";
            int compareResult = 0;

            Console.WriteLine("Give {0} values for 1 array:", sizeArrays);

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("Value {0}:", i);
                input = Console.ReadLine();
                firstArray[i] = input[0];
            }

            Console.WriteLine("Give {0} values for 2 array:", sizeArrays);

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine("Value {0}:", i);
                input = Console.ReadLine();
                secondArray[i] = input[0];
            }

            //compare elements

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int y = 0; y < secondArray.Length; y++)
                {
                    compareResult = firstArray[i].CompareTo(secondArray[y]);
                    /*
                     1) Less than zero - This instance precedes value.
                     2) Zero - This instance has the same position in the sort order as value.
                     3) Greater than zero - This instance follows value.
                    */

                    if (compareResult == 0)
                    {
                        Console.WriteLine("firstArray[{0}] == secondArray[{1}]", i, y);
                    }
                    else if (compareResult < 0)
                    {
                        Console.WriteLine("firstArray[{0}] < secondArray[{1}]", i, y);
                    }
                    else if (compareResult > 0)
                    {
                        Console.WriteLine("firstArray[{0}] > secondArray[{1}]", i, y);
                    }


                }
            }
        }
    }
}
