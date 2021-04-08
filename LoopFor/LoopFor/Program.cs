using System;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // even numbers
            for (int j = 2; j <= 10; j = j + 2)
            {
                Console.WriteLine("Even num: " + j);
            }

            // odd numbers
            for (int k = 1; k <= 10; k = k + 2)
            {
                Console.WriteLine("Odd num: " + k);
            }
        }
    }
}
