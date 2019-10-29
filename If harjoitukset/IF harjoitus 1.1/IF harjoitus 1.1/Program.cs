using System;

namespace IF_harjoitus_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Choose your number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (userNumber == 0)

                Console.WriteLine("The number is zero");
            else if (userNumber < 0)
            {
                Console.WriteLine("The number is negative");
            }
            Console.ReadKey();
            Console.WriteLine();
            goto Start;
        }

                
            
        }
  }

