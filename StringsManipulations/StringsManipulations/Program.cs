using System;

namespace StringsManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "GFRRCTVBNFDNCGGHBHSDJH";
            string name = "Johnny English";
            string txt2 = " is lengendary";

            // string Concatenation
            string cnc = string.Concat(name, txt2);

            // String Interpolation - substitutes values of variables into placeholders in a string.
            // Note that you do not have to worry about spaces, like with concatenation
            string irp = $"String Interpolation: {name} {txt2}";

            Console.WriteLine("The txt Lenghth is: " + txt.Length);
            Console.WriteLine("To lowercase: " + txt.ToLower());
            Console.WriteLine("To Uppercase: " + name.ToUpper());
            Console.WriteLine("String Concatenation: " + cnc);
            Console.WriteLine(irp);

            // Indexing
            Console.WriteLine(txt[1]);
            Console.WriteLine(txt.IndexOf("R"));

            // Substrings - We need to extrach the youtube unique url id
            string ytUrl = "https://youtu.be/TiGUt_3I8v8";
            int charPosition = ytUrl.IndexOf(".be/");
            Console.WriteLine(ytUrl.Substring(charPosition));
        }
    }
}
