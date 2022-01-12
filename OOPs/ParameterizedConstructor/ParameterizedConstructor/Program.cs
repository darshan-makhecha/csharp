using System;

namespace ParameterizedConstructor
{
    class Program
    {
        public class Employee
        {
            // var declare  (public) 
            public int id;
            public String name;
            public float salary;
            public Employee(int i, String n, float s) // pass 3 parameter differnet data types 
            {
                id = i;
                name = n;
                salary = s;
            }
            public void display()           // display the data 
            {
                Console.WriteLine(id + " " + name + " " + salary);
            }
        }
        class TestEmployee
        {
            public static void Main(string[] args)             // main method 
            {
                Employee e1 = new Employee(101, "abc", 89500.45f);  // object create and pass the parameter 
                Employee e2 = new Employee(20 , "xyz", 490000f);
                e1.display();               // display the data
                e2.display();

            }
        }
    }
}
