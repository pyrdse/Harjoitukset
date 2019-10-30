using System;

namespace Toistorakenne_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("-----------");
            Console.WriteLine("Lets gamble!");
            Console.WriteLine("-----------\n");

            for (int i = 1; i < 14; i++)
            {
                double result = rnd.NextDouble();

                if (result <= 0.4)
                {
                    Console.WriteLine($"{i}. 1");                  
                }
                else if (result > 0.4 && result <= 0.6)
                {
                    Console.WriteLine($"{i}. x");                   
                }
                else
                {
                    Console.WriteLine($"{i}. 2");                  
                }
            }
        }
    }
}
