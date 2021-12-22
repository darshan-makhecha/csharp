using System;

namespace inheritance
{
   
        public class ParentClass        // create a  class which name parentclass
        {
            public ParentClass()       
            {
                Console.WriteLine("Parent Constructor.");
            }
            public void print()
            {
                Console.WriteLine("I'm a Parent Class.");
            }
        }
        public class ChildClass : ParentClass   // create a child class , child class call the parent class
        {
            public ChildClass()
            {
                Console.WriteLine("Child Constructor.");
            }
            public static void Main()       // main method
            {
                ChildClass child = new ChildClass();        // child class object => child
                child.print();      
            }
        }
    
}
