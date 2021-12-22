using System;

class newone { 
        // Interface
        interface IAnimal
        {
            void animalSound();
            void animalcolor();// interface method (does not have a body)
        }

        // dog "implements" the IAnimal interface
        class dog : IAnimal
        {
            public void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The dog says : woow woow");
            }
            public void animalcolor()
            {
                Console.WriteLine("The dog is black ");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                dog mydog = new dog();  // Create a dog object
                mydog.animalSound();
                mydog.animalcolor();
            }
        }
    }
