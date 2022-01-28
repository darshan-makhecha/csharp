using System;

namespace pointer
{
    class MyClass
    {
        public unsafe void Method()
        {
            int x = 10;
            int y = 20;
            int* ptr1 = &x;
            int* ptr2 = &y;
            Console.WriteLine("the address is: ");
            Console.WriteLine((int)ptr1);// Displays the memory address  
            Console.WriteLine((int)ptr2);
            Console.WriteLine("the value is  :");
            Console.WriteLine(*ptr1);
            Console.WriteLine(*ptr2);
        }
    }
    class MyClient
    {
        public static void Main()
        {
            MyClass mc = new MyClass();
            mc.Method();
        }
    }
}

