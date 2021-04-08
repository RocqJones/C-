using System;

namespace SwitchStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 7;

            switch (day)
            {
                case 4:
                    Console.WriteLine("It's Thurday");
                    break;

                case 5:
                    Console.WriteLine("It's Friday");
                    break;

                default:
                    Console.WriteLine("Looking forward to the weekend");
                    break;
            }
        }
    }
}
