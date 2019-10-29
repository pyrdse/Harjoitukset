using System;

namespace Itsearviointi_harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a word/sentence and I will print it as many time as it has letters: ");
            string userInput = Console.ReadLine();

            int numberOfLetters = userInput.Length;

            for (int i = 1; i < numberOfLetters; i++)
            {
                Console.WriteLine(+i + (".") + (" ") + userInput);
            }
        }
    }
}
