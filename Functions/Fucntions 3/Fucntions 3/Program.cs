using System;

namespace Fucntions_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will check if your input is valid.\n");

            int retNumber = NumberFromRange(-20, 20);
            Console.WriteLine($"\n{retNumber} is a valid number.");
            Console.ReadKey();
        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {
            do
            {                   
                Console.WriteLine($"Enter a number between {lowerBound} and {upperBound}");
                string userInput = Console.ReadLine();

                bool number = int.TryParse(userInput, out int userNumber);

                if (number && userNumber >= lowerBound && userNumber <= upperBound)
                {
                    return userNumber;
                }
                else
                {
                    Console.WriteLine("\nInvalid input!");
                }
            } while (true);
        }
    }
}
