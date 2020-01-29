using System;
using System.Collections.Generic;

namespace VowelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u', 'y', 'ä', 'ö' };

            Console.WriteLine("Enter a sentence/word");
            string userInput = Console.ReadLine();           

            for (int i = 0; i < userInput.Length; i++)
            {
                if (vowels.Contains(userInput[i]))
                {
                    total++;
                }
            }
            Console.WriteLine($"Total number of vowels in '{userInput}' is: {total}");
        }
    }
}
