using System;

namespace StringTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program shows the number of characters in user input");
            Console.WriteLine("Write a word or a sentence: ");
            string str = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine($"Number of characters is {str.Length}.");            
        }
    }
}
