using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Doe";
            int age = 23;
            bool isMale = true;
            char grade = 'A';
            double salary = 200400.44D;
            int months = 12;

            double gross = salary * months;

            Console.WriteLine(name);
            Console.WriteLine("Age: " + age + " with grade " + grade);
            Console.WriteLine(name + " earnes Ksh." + gross + " anually.");
            Console.WriteLine(name + " is a male: " + isMale);
        }
    }
}