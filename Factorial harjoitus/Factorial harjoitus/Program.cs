using System;

namespace Factorial_harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;                          // Define variables
            int fact = 1;

            Console.WriteLine("Kertoman laskenta");
            Console.Write("Minkä luvun kertoma lasketaan?: ");


            n = int.Parse(Console.ReadLine());  // Luetaan käyttäjän syöte ja pakotetaan se integer muotoon

            if (n<0)                            // Ehto, jossa testataan käyttäjän syöttämä arvo. Ohjelman logiikka
            {
                Console.WriteLine("Virheellinen syöte");
                Console.ReadLine();
            }
            else
            {
                while (n>0)                     // Silmukka jossa lasketaan kertoman arvo
                {
                    fact = fact * n;            // Lasketaan kertoma
                    n = n - 1;                  // Vähennetään arvoa yhdellä
                }
                Console.WriteLine("Vastaus: " + fact);
                Console.ReadLine();
            }

            

           
        }
    }
}
