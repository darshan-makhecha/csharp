using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace egLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            //LINQ Query using Query Syntax  
            var QuerySyntax = from number  in integerList where obj > 5 select obj;
            //Execution  
            foreach (var item inQuerySyntax)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

    }

    }
}
