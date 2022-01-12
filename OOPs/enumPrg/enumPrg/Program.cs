using System;

namespace enumPrg
{
    public class EnumExample
    {
        public enum Season { WINTER = 10, SPRING, SUMMER, FALL }
        // return value index number
        public static void Main()
        {
            int x = (int)Season.WINTER;
            int y = (int)Season.SUMMER;
            Console.WriteLine("WINTER = {0}", x); //10
            Console.WriteLine("SUMMER = {0}", y); // 12
            Console.WriteLine("===========");
            foreach (string s in Enum.GetNames(typeof(Season))) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
