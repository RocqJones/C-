using System;

namespace PropertiesGETnSET
{
    class Person
    {
        // field
        private string name;

        // property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "John Lenon";
            Console.WriteLine(myObj.Name);
        }
    }
}
