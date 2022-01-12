using System;
using System.Collections.Generic;

namespace stackEg
{
    class Program
    {
        //work on LIFO
        // push()=== add
        // pop() === remove
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Sonoo");
            names.Push("Peter");
            names.Push("James");
            names.Push("Ratan");
            names.Push("Irfan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek()); //last name output
            Console.WriteLine("Pop: " + names.Pop());// delete name which display
            Console.WriteLine("After Pop, Peek element: " + names.Peek()); // second delete name which display
        }
    }
}
