using System;

namespace ClassMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass newObj = new MyClass();
            newObj.model = "Ford Mustang";
            newObj.year = 2018;

            Console.WriteLine(newObj.model + " was manufactured in the year " + newObj.year +
                " and the " + newObj.color + " car has top speed of " + newObj.maxSpeed + "km/h.");

            newObj.fullThrottle();
        }
    }
}
