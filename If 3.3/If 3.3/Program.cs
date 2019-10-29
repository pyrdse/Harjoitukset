using System;

namespace If_3._3
{
    class Program
    {
        static void Main(string[] args)
        {

            int evenNumber = 0;
            int oddNumber = 0;
            int userNumber = 0;
            
            Console.Write("Enter any number: ");

            userNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= userNumber; i++)
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
            Console.WriteLine("Sum of even numbers is: " + evenNumber);
            Console.WriteLine("Sum of odd numbers is: " + oddNumber);


        }
    }
}
