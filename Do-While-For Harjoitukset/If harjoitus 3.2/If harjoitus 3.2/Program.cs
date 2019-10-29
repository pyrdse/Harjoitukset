using System;

namespace If_harjoitus_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;

            Console.Write("This program generates the sum of N numbers. \n");
            Console.Write("\n");
            Console.Write("Enter a Number: ");
            n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Invalid number");
                Console.ReadKey();
            }
            else
            {
                for (i = 0; i <= n; i++)
                {
                    sum = sum + i;
                }

                Console.WriteLine("\nSum of N Numbers : " + sum);
                Console.ReadLine();
            }
                
        }
    }
}
