using System;

namespace Toistorakenne_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Luku   Neliöjuuri \n");

            double i = 0;
            
            
            for (i = 1; i <= 10; i++)
            {
                double neliö = Math.Sqrt(i);
                Console.WriteLine($"{i}       {neliö}");
            }
            Console.ReadKey();

        }
    }
}
