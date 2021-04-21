using System;

namespace EnumsWithSwitch
{
    enum Levels
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main(string[] args)
        {
            Levels levels = Levels.High;

            switch (levels)
            {
                case Levels.Low:
                    Console.WriteLine("Low levels here");
                    break;

                case Levels.Medium:
                    Console.WriteLine("Medium levels here");
                    break;

                case Levels.High:
                    Console.WriteLine("High levels here");
                    break;
            }
        }
    }
}
