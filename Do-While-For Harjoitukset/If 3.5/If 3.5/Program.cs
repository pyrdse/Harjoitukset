using System;

namespace If_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumber = 0;
            int oddNumber = 0;
            int userNumber = 0;

            Console.WriteLine("This program calculates the sum of N even and odd numbers.");
            Console.Write("Enter a positive or negative integer: ");

            userNumber = int.Parse(Console.ReadLine());

            if (userNumber > 0)
            {
                for (int i = 0; i <= userNumber; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenNumber = i + evenNumber;
                    }
                    else
                    {
                        oddNumber = oddNumber + i;
                    }
                }
                Console.WriteLine("Sum of even numbers is " + evenNumber);
                Console.WriteLine("Sum of odd numbers is " + oddNumber);
            }
            else
            {
                for (int i = 0; i >= userNumber; i--)
                {
                    if (i % 2 == 0)
                    {
                        evenNumber = i + evenNumber;
                    }
                    else
                    {
                        oddNumber = oddNumber + i;
                    }
                }
                Console.WriteLine("Sum of even numbers is " + evenNumber);
                Console.WriteLine("Sum of odd numbers is " + oddNumber);
            }
        }
    }
}
