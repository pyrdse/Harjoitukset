using System;
using System.Linq;

namespace Taulukko_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iT = new int[100];
            Random rnd = new Random();

            for(int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(50);
            }

            int sum = iT.Sum();
            int average = sum / 100;
                       

            for (int i = 0; i < iT.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(iT[i]);
            }
            Console.WriteLine($"\nAverage is {average}");
        }
    }
}
