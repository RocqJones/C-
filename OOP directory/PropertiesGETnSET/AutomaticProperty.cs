using System;

namespace PropertiesAndEncapsulation
{
    // Automatic Properties (Short Hand)
    class AutomaticProperty
    {
        // No need to define the field for the property. You only have to write get; and set; inside the property.
        public string Name
        {
            get; set;
        }
    }

    class ProgramMain
    {
        static void main(string[] args)
        {
            AutomaticProperty aObj = new AutomaticProperty();
            aObj.Name = "Luise Lewadoski";
            Console.WriteLine(aObj.Name);
        }
    }
}
