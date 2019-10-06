using System;

namespace IF_harjoitus_1._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Pick three numbers to sort: ");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if((a<b)&&(a<c))
            {
                if (b<c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                    Console.ReadKey();
                }
            }
            else if ((b<a)&&(b<c))
            {
                if (a < c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                    Console.ReadKey();
                }
            }
            else if ((c<a)&&(c<b))
            {
                    if (a<b)
                    {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                    Console.ReadKey();
                }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", c, b, a);
                        Console.ReadKey();
                    }
                }
            }









        }
    }

