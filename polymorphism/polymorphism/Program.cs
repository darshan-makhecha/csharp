using System;

namespace polymorphism
{
    class Printdata
    {
        // define a contructor 
        void print(int i)
        {
            Console.WriteLine("Printing int:" + i);
        }
        void print(double f)
        {
            Console.WriteLine("Printing float:" + f);
        }
        void print(string s)
        {
            Console.WriteLine("Printing string:" + s);
        }
        static void Main(string[] args)
        {
            Printdata p = new Printdata();

            // Call print to print value s
            p.print(5);

            p.print(500.263);

            p.print("Hello C#");
           
        }
    }
}