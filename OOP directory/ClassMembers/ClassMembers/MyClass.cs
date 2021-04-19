using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMembers
{
    // Fields - They are variables inside a class
    class MyClass
    {
        // class members - Fields and methods inside classes
        public string model;            // field
        public string color = "blue";  // field
        public int maxSpeed = 320;     // field
        public int year;               // field

        public void fullThrottle()
        {
            Console.WriteLine("The car is going fast as it can!");
        }
    }
}
