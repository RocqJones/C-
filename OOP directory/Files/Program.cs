using System;
using System.IO; // include input/output namespace

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeTxt = "Hello! this is my first file handling files with C#";

            // write to file
            File.WriteAllText("example.txt", writeTxt);

            // read from file and display output
            string readTxt = File.ReadAllText("example.txt");
            Console.WriteLine(readTxt);
        }
    }
}
