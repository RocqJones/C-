using System;

namespace Abstraction
{
    // Abstract class
    abstract class Animal
    {
        // abstract method
        public abstract void animalSound();
        // Regular method
        public void sleep()     
        {
            Console.WriteLine("Zzz");
        }
    }

    // derived class (inherit from animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Pig object
            Pig mypig = new Pig();
            mypig.animalSound();
            mypig.sleep();
        }
    }
}