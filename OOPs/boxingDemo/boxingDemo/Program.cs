using System;

namespace boxingDemo
{
    class Program
    {
        public static void Main()
        {
            int x;
            object obj;
            x = 10;
            obj = x; // box int x into an object 
            //int Y = (int)obj; //unbox obj to int by casting
            Console.WriteLine(obj);
        }
    }
}
