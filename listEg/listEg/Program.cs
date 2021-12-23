using System;
using System.Collections.Generic;

namespace listEg
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            var names = new List<int>();
            names.Add(12);
            names.Add(18);
            names.Add(40);
            //names.Add("Irfan");

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
