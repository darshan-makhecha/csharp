using System;
using System.Collections.Generic;

namespace hashsetEg
{
    class Program
    { 
        // use of hashset  we add , remove value 
        public static void Main(string[] args)
        {
            // Create a set of strings  
            var names = new HashSet<string>();
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");//will not be added  

           
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
