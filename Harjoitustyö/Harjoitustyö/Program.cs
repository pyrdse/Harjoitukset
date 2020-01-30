using System;
using System.Globalization;
namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 0;

            do
            {
                menuChoice = openMenu();

                if (menuChoice == 1)
                {
                    RefNumValidityCheck();
                }
                else if (menuChoice == 2)
                {
                    CreateNewRefNum();
                }
                else if (menuChoice == 3)
                {
                    CreateMultipleRefNum();
                }
            } while (menuChoice != 4);
           
        }

        private static int openMenu()
        {
            Console.WriteLine("Menu: pick a number and press ENTER \n");
            Console.WriteLine("1. Check the validity of given reference number.");
            Console.WriteLine("2. Create a new reference number.");
            Console.WriteLine("3. Create multiple reference numbers.");
            Console.WriteLine("4. Exit.");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }

        private static void RefNumValidityCheck()
        {
                      
            Console.WriteLine("Enter a finnish reference number: ");
            string userRefNum = Console.ReadLine();

            
            if (userRefNum.Length > 20)                                             
            {
                Console.WriteLine("Reference number max lenght is 20 characters");
            }
            else if (userRefNum.Length < 4)
            {
                Console.WriteLine("Reference number min lenght is 4 characters");
            }
            else
            {
                int sum = 0;
                int[] multiplier = new int[] { 7, 3, 1 };
                int[] refArr = new int[userRefNum.Length];

                for (int i = 0; i < userRefNum.Length; i++)
                {
                    refArr[i] = int.Parse(userRefNum[i].ToString());
                }
                for (int i = 0; i < refArr.Length; i++)
                {
                    sum += refArr[refArr.Length - 1 - i] * multiplier[i % 3];
                }
                int checkNum = 10 - (sum % 10);

                if (checkNum == 10)
                {
                    checkNum = 0;
                }
                if (refArr[refArr.Length - 1] == checkNum)
                {
                    Console.WriteLine($"\n{userRefNum} - OK\n");
                }
                else
                {
                    Console.WriteLine($"\n{userRefNum} - Incorrect\n");
                }
            }
        }

        static void CreateNewRefNum()
        {
            string userInput;

            do
            {
                Console.WriteLine("Enter the firs part of reference number that is 3-19 characters long: ");
                userInput = Console.ReadLine();

            } while (userInput.Length <= 3 || userInput.Length >= 19);
            int sum = 0;
            int [] multiplier = new int[] { 7, 3, 1 };
            int[] refArr = new int[userInput.Length];

            for (int i = 0; i < userInput.Length; i++)
            {
                refArr[i] = int.Parse(userInput[i].ToString());
            }
            for (int i = 0; i < refArr.Length; i++)
            {
                sum += refArr[refArr.Length - 1 - i] * multiplier[i % 3];
            }
            int checkNum = 10 - (sum % 10);

            if (checkNum == 10)
            {
                checkNum = 0;
            }
            Console.WriteLine($"Syöte: {userInput}");
            string userOutPut = userInput + checkNum;
            
            for (int i = 1; i < userOutPut.Length; i++)
            {
                if(i % 5 == 0)
                {
                    userOutPut = userOutPut.Insert(i, " ");
                }
            }
            Console.WriteLine($"\nUusi viitenumero: {userOutPut}\n");
            
        }

        private static void CreateMultipleRefNum()
        {
            Console.Write($"This feature is currently unavailable.\n\n");
        }
    }
}
