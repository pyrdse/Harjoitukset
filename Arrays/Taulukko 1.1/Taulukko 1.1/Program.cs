using System;

namespace Taulukko_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal[] productPrice = new decimal[] { 7.96M, 72.00M, 99.90M };
            int[] productAmount = new int[] { 1, 3, 2 };
            decimal[] productTotalPrice = new decimal[3];

            for (int i = 0; i < productTotalPrice.Length; i++)
            {
                productTotalPrice[i] = productAmount[i] * productPrice[i];
                Console.WriteLine($"Product {i + 1}: {productTotalPrice[i]}€");
            }
        }
    }
}
