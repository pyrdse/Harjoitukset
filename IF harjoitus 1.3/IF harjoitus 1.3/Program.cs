using System;

namespace IF_harjoitus_1._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber > 0 && userNumber % 2 == 0)
            {
                Console.WriteLine("The number is positive and even");

            }
            else if (userNumber < 0 && userNumber % 2 == 0)
            {
                Console.WriteLine("The number is negative and even");
            }
            else if (userNumber > 0 && userNumber % 2 == 1)
            {
                Console.WriteLine("The number is positive and odd");
            }
            else if(userNumber==0&&userNumber%2==0)
            {
                Console.WriteLine("The number is zero and even");
            }
            else
            {
                Console.WriteLine("The number is negative and odd");

            }
    {

    }
            




        }
    }
}
            


                

            

            
        
    

