using System;


namespace StringTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program counts the number of 'L' used in the word/sentence");
            Console.WriteLine("Write a word/sentence");
            string str = string.Empty;
            str = Console.ReadLine().ToUpper();

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'L')
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.Write($"There is {count} letter L's in your input ({str})");                 
        }
    }
}
