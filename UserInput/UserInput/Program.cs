using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name? ");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter Second Name? ");
            string sName = Console.ReadLine();

            // since you cannot implicitly convert type 'string' to 'int' convert
            Console.WriteLine("Your age?");
            int uAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your full name is: " + fName + " " + sName + " and you are " + uAge + " years old.");
        }
    }
}
