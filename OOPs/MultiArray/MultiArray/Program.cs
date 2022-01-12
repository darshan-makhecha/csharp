using System;

namespace MultiArray
{
    class Program
    {
        /*
         * in array there are 4 types 
         * 1. Single-dimensional arrays(data ne stroe kare and numberic and string i=starting position 0 )
           2. Multidimensional arrays or rectangular arrays (matrix na form ma )
                eg int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
           3. Jagged arrays (items individually use thay)
         * 
         *  here example of jagged array 
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Single Dimension Array Sample");
            // Single dim array
            string[] strArray = new string[] {
                 "Mahesh Chand",
                "Mike Gold",
                "Raj Beniwal",
                "Praveen Kumar",
                "Dinesh Beniwal"
};
            // Read array items using foreach loop
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Multi-Dimension Array Sample");
            string[,] string2DArray = new string[2, 2] {
            {
                "Rosy",
                "Amy"
            }, {
                "Peter",
                "Albert"
            }
};
            foreach (string str in string2DArray)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Jagged Array Sample");
            int[][] intJaggedArray3 = {
                new int[] {
                    2,
                    12
                },
                new int[] {
                    14,
                    14,
                    24,
                    34
                },
                new int[] {
                    6,
                    16,
                    26,
                    36,
                    46,
                    56
                }
            };
            // Loop through all itesm of a jagged array
            for (int i = 0; i < intJaggedArray3.Length; i++)
            {
                Console.Write($"Element({i}): ");
                for (int j = 0; j < intJaggedArray3[i].Length; j++)
                {
                    Console.Write($"{intJaggedArray3[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
