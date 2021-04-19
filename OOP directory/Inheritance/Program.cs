using System;

namespace Inheritance
{
    // base (parent) class
    class Vehicle
    {
        public string brand = "BMW";    // vehicle field
        public void honk()              // vehicle method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    // derived (child) class
    class Car : Vehicle
    {
        public string modelName = "M5 Competition"; // car field
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.honk();
            Console.WriteLine(myCar.brand + " " +  myCar.modelName);
        }
    }
}
