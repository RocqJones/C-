using System;

namespace ClassesAndObjects
{
    // class with main method
    class Program
    {

        string attr = "This runs in the main method.";

        static void Main(string[] args)
        {
            // create object of a class
            Program myprog = new Program();
            Cars cars = new Cars();

            Console.WriteLine(myprog.attr);

            // instantiate new array
            string[] new_arr = cars.carModels;

            // print each car
            foreach (string i in new_arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
