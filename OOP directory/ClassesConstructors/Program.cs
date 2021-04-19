using System;

namespace ClassesConstructors
{
    // constructor is a special method that is used to initialize objects.
    // The advantage of a constructor, is that it is called when an object of a class is created.
    // It can be used to set initial values for fields
    class Program
    {
        // field
        public string model;
        public string otherModel;

        // class constructor
        public Program()
        {
            model = "Ford Mustang";
        }

        // constructor wih params
        public Program(string anotherModel)
        {
            otherModel = anotherModel;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Program newObj = new Program("Audi RS7");

            Console.WriteLine(program.model);
            Console.WriteLine(newObj.otherModel);
        }
    }
}
