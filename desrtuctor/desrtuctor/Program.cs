using System;

namespace desrtuctor
{
        class Destructor
        {
            public Destructor()
            {
                Console.WriteLine("constructor object created");
            }
            ~Destructor()
            {
                Console.WriteLine("object is destroyed");
            }
        }
}
