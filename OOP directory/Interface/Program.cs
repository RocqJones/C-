using System;

namespace Interface
{
    // interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // add another intercases
    interface ISecondInterface
    {
        void myOtherMethod();
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal, ISecondInterface
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Another interface method implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create object
            Pig pig = new Pig();
            pig.animalSound();
            pig.myOtherMethod();
        }
    }
}