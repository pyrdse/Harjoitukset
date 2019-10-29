using System;

namespace Itsearviointi_tehtävä_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a word/sentence and I will print it five times: ");
            string userInput = Console.ReadLine();
            int n = 1;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(+n+(".")+(" ")+userInput);
                n++;
            }

        }

    


    }

}
