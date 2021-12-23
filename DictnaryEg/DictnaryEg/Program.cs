using System;
using System.Collections.Generic;

namespace DictnaryEg
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> nm = new Dictionary<int, string>();

            nm.Add(105 , "abc");
            nm.Add(106, "abc");
            nm.Add(107, "abc");
            nm.Add(108, "abc");
            

            foreach (KeyValuePair<int, string> n in nm) {
                Console.WriteLine(n.Key + " => " + n.Value);
            }

        }
    }
}
