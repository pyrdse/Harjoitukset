using System;

namespace If_3._4
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
            if (n > 0)
            {

                for (i = 0; i <= n; i++)
                {
                    sum = sum + i;
                    
                }

                Console.WriteLine("\nSum of N Numbers : " + sum);
                Console.ReadLine();
            }
            else
            {
                if (n < 0)
                {
                    for (i=0; i >= n; i--)
                    {
                        sum = sum+i;
                        
                    }
                    Console.WriteLine("\nSum of N Numbers : " + sum);
                    Console.ReadLine();
                }
            }
        }
    }
}
