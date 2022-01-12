using System;

namespace extra
{
    public class data
    {
        public int id;
        public String name;
        public int total;

        public data(int id, String name , int total)
        { 
            //current instance of class
            this.id = id;
            this.name = name;
            this.total = total;
    

        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + total);

        }
       
    }
    class stud
    {
        public static void Main(string[] args)
        {
            data s1 = new data(101, "abc" ,250 );
            data s2 = new data(101, "xyz" , 245);

            s1.display();
            s2.display();

        }
    }
}