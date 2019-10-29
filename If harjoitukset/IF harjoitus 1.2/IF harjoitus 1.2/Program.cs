using System;

namespace IF_harjoitus_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            Console.WriteLine("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber % 2 == 0)
            {

                Console.WriteLine("Entered number is an even number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Entered number is an odd number");
                Console.ReadLine();
            }
        }
    }
}
