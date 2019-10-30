using System;

namespace Itsearviointi_tehtävä_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());
            decimal number2 = Convert.ToDecimal(Console.ReadLine());
           
            Console.WriteLine("\n1.Number: "+number1);
            Console.WriteLine("2.Number: " + number2);
            Console.WriteLine("\n");

            Console.WriteLine(number1 + "+" + number2 + "=" + String.Format("{0:0.00}", number1 + number2));
            Console.WriteLine(number1 + "-" + number2 + "=" + String.Format("{0:0.00}", number1 - number2));
            Console.WriteLine(number1 + "x" + number2 + "=" + String.Format("{0:0.00}", number1 * number2));
            Console.WriteLine(number1 + "/" + number2 + "=" + String.Format("{0:0.00}", number1 / number2));
        }
    }
}
