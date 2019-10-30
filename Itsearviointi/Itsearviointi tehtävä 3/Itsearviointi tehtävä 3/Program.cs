using System;

namespace Itsearviointi_tehtävä_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = -1;
            int userGuess = 0;
            int sum = 0;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Lets play a round of good old guessing game!");
            Console.WriteLine("---------------------------------------------\n");
            Console.WriteLine("Enter numbers between -10 and 10 until you enter the correct one: \n");

            while (userGuess != numberToGuess)
            {
                
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numberToGuess)
                {
                    sum += userGuess;
                }
                else if (userGuess < numberToGuess)
                {
                    sum += userGuess;
                }
                else
                {
                    Console.WriteLine("\nThe sum of guessed numbers is {0}", sum);
                }


            }

        }
    }
}
