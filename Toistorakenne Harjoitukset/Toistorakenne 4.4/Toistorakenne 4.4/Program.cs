using System;

namespace Toistorakenne_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int k;
            int i = 0;

            int heads = 0;
            int tails = 0;
            
            
            Console.WriteLine("Lets play some heads or tails, shall we?");
            Console.WriteLine("How many times you want the coin to be flipped? ");
            k = int.Parse(Console.ReadLine());

            for (i = 0; i < k; i++)
            {
                int result = rnd.Next(0, 2);

                if (result == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine("Coin was flipped " + k + " times.");
            Console.WriteLine("Heads was flipped: "+ heads);
            Console.WriteLine("Tails was flipped: "+ tails);
            return;
        }

    }
}
