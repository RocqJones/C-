﻿using System;

namespace LoopForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
