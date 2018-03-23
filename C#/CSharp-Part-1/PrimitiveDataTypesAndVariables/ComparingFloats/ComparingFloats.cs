/*
Problem 13.*	Comparing Floats
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

Examples:

Number a	Number b	Equal (with precision eps=0.000001)	Explanation
5.3	6.01	false	The difference of 0.71 is too big (> eps)
5.00000001	5.00000003	true	The difference 0.00000002 < eps
5.00000005	5.00000001	true	The difference 0.00000004 < eps
-0.0000007	0.00000007	true	The difference 0.00000077 < eps
-4.999999	-4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
4.999999	4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            decimal a = 5.3m;
            decimal b = 6.01m;
            decimal difference= Math.Abs(a-b);
            decimal eps = 0.000001m;

            if (difference<eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);
            }
            else if(difference == eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("Border case. The difference {0} == eps. We consider the numbers are different.", difference);
            }
            else
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference of {0} is too big (> eps)", difference);

            }
            a = 5.00000001m;
            b = 5.00000003m;
            difference = Math.Abs(a - b);
            if (difference < eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);
            }
            else if (difference == eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("Border case. The difference {0} == eps. We consider the numbers are different.", difference);
            }
            else
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);

            }
            a = 5.00000005m;
            b = 5.00000001m;
            difference = Math.Abs(a - b);
            if (difference < eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);
            }
            else if (difference == eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("Border case. The difference {0} == eps. We consider the numbers are different.", difference);
            }
            else
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);

            }
            a = -0.0000007m;
            b = 0.00000007m;
            difference = Math.Abs(a - b);
            if (difference < eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);
            }
            else if (difference == eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("Border case. The difference {0} == eps. We consider the numbers are different.", difference);
            }
            else
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);

            }
            a = -4.999999m;
            b = -4.999998m;
            difference = Math.Abs(a - b);
            if (difference < eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);
            }
            else if (difference == eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("Border case. The difference {0} == eps. We consider the numbers are different.", difference);
            }
            else
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);

            }
            a = 4.999999m;
            b = 4.999998m;
            difference = Math.Abs(a - b);

            if (difference < eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);
            }
            else if (difference == eps)
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("Border case. The difference {0} == eps. We consider the numbers are different.", difference);
            }
            else
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
                Console.WriteLine("The difference {0} < eps", difference);

            }
        }
    }
}
