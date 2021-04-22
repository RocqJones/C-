using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNums = { 1, 2, 3 };
                Console.WriteLine(myNums[10]);
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            // finally statement lets you execute code, after try...catch, regardless of the result
            finally
            {
                Console.WriteLine("The 'try catch' block finished!");
            }
        }
    }
}
