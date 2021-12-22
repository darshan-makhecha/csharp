using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] staticIntArray = new int[3];  //declare an array
            staticIntArray[0] = 1;              // define value
            staticIntArray[1] = 3;
            staticIntArray[2] = 5;
            // Read array items one by one
            Console.WriteLine(staticIntArray[0]);
            Console.WriteLine(staticIntArray[1]);
            Console.WriteLine(staticIntArray[2]);

            Console.WriteLine("====================================");
            // Initialize a dynamic array items during declaration
            string[] strArray = new string[] {
                 "Mahesh Chand",
                "Mike Gold",
                "Raj Beniwal",
                "Praveen Kumar",
                "Dinesh Beniwal"
            };
            // Read array items using foreach loop
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
