using System;

namespace StringTaskPalindrome
{
    class Program
    {
        
        static void Main(string[] args)       
        {
            string userInput = string.Empty;
            string reverse = string.Empty;

            Console.WriteLine("This program checks whether a string is palindrome or not.");
            Console.WriteLine("Enter a string");
            userInput = Console.ReadLine();

            userInput = userInput.Replace(" ", "");
            reverse = reverse.Replace(" ", "");
            

            for(int i = userInput.Length-1; i >=0; i--)
            {               
                reverse += userInput[i].ToString();
            }
            if (reverse == userInput)
            {
                Console.WriteLine("\nString is palindrome.\nEntered string was {0} and reverse string is {1}", userInput, reverse);
            }
            else
            {
                Console.WriteLine("\nString is not palindrome. \nEntered string was {0} and reverse string is {1}", userInput, reverse);
            }
        }
    }
}
