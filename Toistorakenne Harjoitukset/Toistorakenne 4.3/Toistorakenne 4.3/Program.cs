using System;

namespace Toistorakenne_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will print 20 random numbers, 5 numbers/line.\n");

            Random rnd = new Random();
            int i = 0;
            int n = 1;

            while (n < 5)
            {
                Console.Write("Line " + n + ": ");
                while (i < 4)
                {
                    Console.Write(rnd.Next(50) + ", ");
                    i++;
                    if (i == 4)
                    {
                        Console.Write(rnd.Next(50));
                    }
                }
                i = 0;
                n++;
                Console.WriteLine();               
            }
        }
    }
}
