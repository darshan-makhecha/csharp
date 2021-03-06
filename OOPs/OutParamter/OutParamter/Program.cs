using System;

namespace OutParamter
{
    class Program
    {
        // out is used with variables and method parameters.
        /*
         *  The out paramters are always passed by reference for both, the value type and the reference type data types
         */
        public void Show(out int a, out int b) // Out parameter  
        {
            int square = 5;
            a = square;
            b = square;
            // Manipulating value  
            a *= a;
            b *= b;
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val1 = 50, val2 = 100;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before passing \n val1 = " + val1 + " \n val2 = " + val2);
            program.Show(out val1, out val2); // Passing out argument  
            Console.WriteLine("Value after passing \n val1 = " + val1 + " \n val2 = " + val2);
        }
    }
}
