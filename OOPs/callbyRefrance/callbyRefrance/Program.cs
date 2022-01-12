using System;

namespace callbyRefrance
{
    class Program
    {
        public void Show(ref int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            //In Call by value, a copy of the variable is passed whereas in Call by reference, a variable itself is passed.
            int val = 50;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before calling the function " + val);
            program.Show(ref val); // Calling Function by passing reference            
            Console.WriteLine("Value after calling the function " + val);          
            Console.WriteLine("Value  " + val);
        }
    }
}
