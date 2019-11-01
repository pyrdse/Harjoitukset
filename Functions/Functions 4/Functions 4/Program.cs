using System;

namespace Functions_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 positive integer numbers.");
            Console.WriteLine(Numbers());
            Console.ReadKey();
        }

        static string Numbers()
        {
            int userInput = 0;
            bool num = false;
            int highest = 0;
            int placement = 0;
            string userNumbers = "";

            for (int i = 1; i <= 10; i++)
            {
                do
                {
                    Console.Write($"{i}: ");
                    num = int.TryParse(Console.ReadLine(), out userInput);
                    if (!num || userInput < 1)
                    {
                        Console.WriteLine($"Number {userInput} is not a positive number!");
                    }
                    else if (highest < userInput)
                    {
                        highest = userInput;
                        placement = i;
                    }

                }
                while (userInput < 0);

                userNumbers += $"{userInput} ";
            }
            Console.WriteLine($"\nYour numbers: {userNumbers}\n");
            return ($"Highest number was {highest} and it was your {placement} number.");
        }

    }

       
        

        

          
    
}
