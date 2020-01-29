using System;

namespace StringTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program replaces the character 'e' with '@'");
            Console.WriteLine("Write a word or a sentence: ");
            string str = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(str.Replace('e', '@'));
        }
    }
}
