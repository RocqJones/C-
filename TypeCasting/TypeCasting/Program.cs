using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 74.87;
            int myInt = (int) myDouble;
            bool myBool = true;

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}
