using System;

namespace Polymorphism
{
    // base (parent) class
    class Animal
    {
        // By adding the "virtual" keyword you provide an option to override the base class method
        // and by using the "override" keyword for each derived class methods
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    // derived (child) class
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee!");
        }
    }

    // derived (child) class
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();

            animal.animalSound();
            pig.animalSound();
            dog.animalSound();
        }
    }
}
