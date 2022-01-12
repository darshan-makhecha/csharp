using System;

namespace constructor
{
    class Program
    {
        // default constructor
        public class Employee   // main class employee
        {
            public Employee() 
            {
                Console.WriteLine("Default Constructor calling");
            }
           
            public static void Main(string[] args)
            {
                Employee e1 = new Employee();
                Employee e2 = new Employee();

            }
        }
       
    }
}


