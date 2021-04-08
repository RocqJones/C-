using System;
using System.Linq;

namespace ArraysL
{
    class Program
    {
        static void Main(string[] args)
        {
            // def arr
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // sort strings
            string[] cs = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cs);
            foreach (string j in cs)
            {
                Console.WriteLine(j);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int k in myNumbers)
            {
                Console.WriteLine(k);
            }

            // System.Linq Namespace
            Console.WriteLine("Max: " + myNumbers.Max());  // returns the largest value
            Console.WriteLine("Min: " + myNumbers.Min());  // returns the smallest value
            Console.WriteLine("Sum: " + myNumbers.Sum());  // returns the sum of elements
        }
    }
}
