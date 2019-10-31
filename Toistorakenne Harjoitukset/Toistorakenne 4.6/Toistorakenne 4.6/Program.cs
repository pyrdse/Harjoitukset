using System;

namespace Toistorakenne_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int six = 0;

            for (int n = 0; n <= 1000; n++)
            {
                int result = rnd.Next(6);

                Console.WriteLine($"{n}. {result + 1}");
                if (result + 1 == 6)
                {
                    six++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Number six was scored {six} times.");
        }
    }
}
