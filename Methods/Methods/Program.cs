using System;

namespace Methods
{
    class Program
    {
        static void myMethod()
        {
            Console.WriteLine("Run me");
        }

        // Param arguments and default params
        static void myMethodTwo(string fname, string sname = "Telles")
        {
            Console.WriteLine(fname + " " + sname);
        }

        static int doCalc(int x, int y)
        {
            double z = 122.67;

            return (int)(double) ((x * z) / y);
        }

        static void Main(string[] args)
        {
            myMethod();
            myMethodTwo("John"); // sname picks from default param
            myMethodTwo("Maguire", "Loise");
            Console.WriteLine(doCalc(23, 45));
        }
    }
}
