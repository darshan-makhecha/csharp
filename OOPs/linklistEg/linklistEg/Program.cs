using System;
using System.Collections.Generic;

namespace linklistEg
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  linklist prg
             * AddLast() , AddFirst() , AddBefore(), AddAfter()
             */
            var names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");

            //insert new element before "Peter"  
            LinkedListNode<String> node = names.Find("Peter");
            names.AddBefore(node, "John");
            names.AddAfter(node, "Lucy");   //insert new element after "Peter" 

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
