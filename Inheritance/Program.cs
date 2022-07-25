using System;
using AnimalClasses;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            // DONE

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            // DONE

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            // DONE



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird newBird = new Bird("Parakeet", true, 20, 5.7, "Cacaw", "Polly", "A Tropical Bird", true);
            newBird.CreativeDisplay();
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile newReptile = new Reptile("Python", true, 50, 4.3, "Hiss", "Mr. Scales", "A scaley boi", false);
            newReptile.CreativeDisplay();
        }
    }
}
