using System;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // // prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            // // prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
                {
                    Console.WriteLine(i);
                }
            }

            // print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }

        }
    }
}
