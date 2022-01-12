using System;

namespace methdOverrideDemo
{
    class baseClass
    {
        public virtual void Greetings()    //virtual keyword
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }
    class subClass : baseClass      // inherit base class
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("subClass Saying Hello!");
          
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            baseClass obj1 = new subClass();
            subClass o1 = new subClass();

            obj1.Greetings(); // subclass ne call kare
            Console.WriteLine("===========");
            o1.Greetings(); // subclass ne call karine baseclass ne inherit kare...
        }
    }
}
