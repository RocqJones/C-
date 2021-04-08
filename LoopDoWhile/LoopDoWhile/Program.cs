using System;

namespace LoopDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;

            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j <= 10);
        }
    }
}
