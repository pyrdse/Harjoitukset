using System;

namespace Taulukko_2._0_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loton oikea rivi on:");

            Random rnd = new Random();
            int[] lottery = new int[7];

            for (int i = 0; i < lottery.Length;)
            {
                lottery[i] = rnd.Next(40);
                if (lottery[i] != 0)
                {
                    i++;
                }
            }
            bool didSwap;
            do
            {
                didSwap = false;
                for (int i = 0; i < lottery.Length - 1; i++)
                {
                    if (lottery[i] > lottery[i + 1])
                    {
                        int temp = lottery[i + 1];
                        lottery[i + 1] = lottery[i];
                        lottery[i] = temp;
                        didSwap = true;
                    }
                }
            } while (didSwap);
            for (int x = 0; x != lottery.Length; x++)
            {
                Console.Write(lottery[x]);
                if (x < lottery.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"\nLisänumero: {rnd.Next(4)}");
            Console.WriteLine($"Tuplausnumero: {rnd.Next(40)}");
        }
    }
}
