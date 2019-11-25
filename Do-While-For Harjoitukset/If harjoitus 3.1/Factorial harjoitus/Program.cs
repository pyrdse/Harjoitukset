using System;

namespace Factorial_harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;                          
            int fact = 1;

            Console.WriteLine("This program will calculate the factorial of a given number");
            Console.Write("Enter a positive integer: ");


            n = int.Parse(Console.ReadLine());  

            if (n<0)                            
            {
                Console.WriteLine("Invalid feed.");
                Console.ReadLine();
            }
            else
            {
                while (n>0)                     
                {
                    fact = fact * n;            
                    n = n - 1;                  
                }
                Console.WriteLine("The answer is: " + fact);
                Console.ReadLine();
            }
            

            

           
        }
    }
}
