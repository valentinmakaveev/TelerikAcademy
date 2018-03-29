/*
Problem 15.* Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
Examples:

n	binary representation of n	binary result	result
1140867093	01000100 00000000 01000000 00010101	01000010 00000000 01000000 00100101	1107312677
255406592	00001111 00111001 00110010 00000000	00001000 00111001 00110010 00111000	137966136
4294901775	11111111 11111111 00000000 00001111	11111001 11111111 00000000 00111111	4194238527
5351	00000000 00000000 00010100 11100111	00000100 00000000 00010100 11000111	67114183
2369124121	10001101 00110101 11110111 00011001
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give 32-bit unsigned integer");
            int n = int.Parse(Console.ReadLine());
            int mask;
            int nAndMask;
            int bit;
            int resultNumber = 0;
            List<int> positions = new List<int>();
            positions.Add(3);
            positions.Add(4);
            positions.Add(5);
            List<int> bits = new List<int>();

            List<int> PositionsChangePlace = new List<int>();
            PositionsChangePlace.Add(24);
            PositionsChangePlace.Add(25);
            PositionsChangePlace.Add(26);
            List<int> bitsChangePlace = new List<int>();

            for (int i = 0; i < positions.Count; i++)
            {
                mask = 1 << positions[i];
                nAndMask = n & mask;
                bit = nAndMask >> positions[i];
                bits.Add(bit);
            }
            for (int i = 0; i < PositionsChangePlace.Count; i++)
            {
                mask = 1 << PositionsChangePlace[i];
                nAndMask = n & mask;
                bit = nAndMask >> PositionsChangePlace[i];
                bitsChangePlace.Add(bit);
            }

            for (int i = 0; i < bits.Count; i++)
            {
                if (bits[i] == 1)
                {
                    mask = 1 << PositionsChangePlace[i];
                    resultNumber = n | mask;
                    
                }
                else
                {
                    mask = ~(1 << PositionsChangePlace[i]);
                    resultNumber = n & mask;
                }
            }

            for (int i = 0; i < bitsChangePlace.Count; i++)
            {
                if (bitsChangePlace[i] == 1)
                {
                    mask = 1 << positions[i];
                    resultNumber = n | mask;

                }
                else
                {
                    mask = ~(1 << positions[i]);
                    resultNumber = n & mask;
                }
            }
            Console.WriteLine("Result: {0}", resultNumber);

        }
    }
}
