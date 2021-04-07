using System;

namespace StringsManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "GFRRCTVBNFDNCGGHBHSDJH";
            string name = "Johnny English";
            string txt2 = " is lengendary";

            // string Concatenation
            string cnc = string.Concat(name, txt2);

            Console.WriteLine("The txt Lenghth is: " + txt.Length);
            Console.WriteLine("To lowercase: " + txt.ToLower());
            Console.WriteLine("To Uppercase: " + name.ToUpper());
            Console.WriteLine("String Concatenation: " + cnc);
        }
    }
}
