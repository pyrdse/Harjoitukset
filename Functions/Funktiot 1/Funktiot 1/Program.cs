using System;

namespace Funktiot_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa syötetyn luvun mukaisen määrän tähtiä.");
            Console.Write("Syötä kokonaisluku: ");
            int userInput = int.Parse(Console.ReadLine());
            if(IsValidNumber(userInput))
            {
                string strStars = GenerateAmountOfStars(userInput);
                Console.WriteLine(strStars);
            }
            else
            {
                Console.WriteLine($"Numero {userInput} ei ole sallittu luku!");
            }
            
        }

        static bool IsValidNumber (int userInput)
        {
            return userInput > 0;
            /*
            if (userInput > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }


        /// <summary>
        /// Ohjelma generoi parametrin määrän tähtiä
        /// </summary>
        /// <param name="AmountOfStars"></param>
        /// <returns></returns>

        static string GenerateAmountOfStars(int AmountOfStars)
        {
            string stars = "";
            for (int i = 0; i < AmountOfStars; i++)
            {
                stars = stars + "*";            //stars += "*"
            }
            return stars;

        }
    }

}
