using System;

namespace methodOverloding
{
    public class Demo
    {
        // two or more than method having same name but different parameter is what we call method overloading
        public static int Display(int one, int two)
        {
            return one * two;
        }

        public static int Display(int one, int two, int three)
        {
            return one * two * three;
        }

        public static int Display(int one, int two, int three, int four)
        {
            return one * two * three * four;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Multiplication of two numbers: " + Demo.Display(10, 15));
            Console.WriteLine("Multiplication of three numbers: " + Demo.Display(8, 13, 20));
            Console.WriteLine("Multiplication of four numbers: " + Demo.Display(3, 7, 10, 7));
        }
    }
}
