using System;
using System.Collections.Generic;


namespace sortedSetEg
{
    class Program
    {
        // sorting
        // ascending order ma
        static void Main(string[] args)
        {
            var nm = new SortedSet<String>();
            nm.Add("xyz");
            nm.Add("abc");
            nm.Add("def");
            nm.Add("hij");
            foreach (var name in nm)
            {
                Console.WriteLine(name);
            }

        }
    }
}
