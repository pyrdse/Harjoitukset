using System;

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
            Console.ReadKey();
        }

        private static int openMenu()
        {
            Console.WriteLine("This is a finnish reference number creator.\nMenu: press number for operation: \n");
            Console.WriteLine("1. Check the validity of given reference number.");
            Console.WriteLine("2. Create a new reference number.");
            Console.WriteLine("3. Create multiple reference numbers.");
            Console.WriteLine("4. Exit.");

        }
    }
}
