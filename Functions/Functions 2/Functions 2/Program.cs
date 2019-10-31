using System;

namespace Functions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Number "+GetMin(firstNum, secondNum) +" "+"is lower than " + GetMax(firstNum, secondNum));
        }

        public static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        public static int GetMin(int first, int second)
        {
            if (first < second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }

}
