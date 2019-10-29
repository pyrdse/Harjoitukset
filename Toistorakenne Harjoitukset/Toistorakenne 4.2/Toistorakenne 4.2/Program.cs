using System;

namespace Toistorakenne_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma tulostaa kertotaulun luvuille 1-9. \n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            int i, k, p;
            for (i = 1; i <= 9; i++)
            {
                for (k = 1; k <= 9; k++)
                {
                    p = i * k;
                    Console.WriteLine(i + "x" + k + "=" + p + "  ");
                }
                Console.WriteLine("   ");            
            }
        }
    }
}

