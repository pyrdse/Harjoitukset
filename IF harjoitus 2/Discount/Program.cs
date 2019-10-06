using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double discount = 0;
            int originalPrice = 16;
            string varusMies;
            string opiskelija;
            string mtk;
            int age;


            Console.WriteLine("Lasketaan sinulle alennus");
            Console.WriteLine("Oletko varusmies? Y / N");
            varusMies = Console.ReadLine();



            if (varusMies.ToUpper() == "Y")
            {
                discount = 0.5;
                Console.WriteLine($"Lipun hinta on {originalPrice - (discount * originalPrice)} euroa");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Oletko opiskelija? Y / N");
                opiskelija = Console.ReadLine();
                if (opiskelija.ToUpper() == "Y")
                {
                    Console.WriteLine("Oletko mtk:n jäsen? Y / N");
                    mtk = Console.ReadLine();
                    if (mtk.ToUpper() == "Y")
                    {
                        discount = 0.6;
                        Console.WriteLine($"Lipun hinta on {originalPrice - (discount * originalPrice)} euroa");

                    }
                    else if (mtk.ToUpper() == "N")
                        discount = 0.45;
                    Console.WriteLine($"Lipun hinta on {originalPrice - (discount * originalPrice)} euroa");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Kuinka vanha olet? ");
                    age = Convert.ToInt32(Console.ReadLine());

                    if (age < 7)
                    {
                        Console.WriteLine("onneks olkoo kakara lippus on ilmanen vittu");
                        Console.ReadKey();
                    }
                    else if (age >= 7 && age <= 15 || age >= 65)
                    {
                        discount = 0.50;
                        Console.WriteLine($"Lipun hinta on {originalPrice - (discount * originalPrice)} euroa");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Oletko mtk:n jäsen? Y / N");
                        mtk = Console.ReadLine();

                        if (mtk.ToUpper() == "Y")
                        {
                            discount = 0.15;
                            Console.WriteLine($"Lipun hinta on {originalPrice - (discount * originalPrice)} euroa");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Lipun hinta on 16e");
                            Console.ReadKey();
                        }







                    }


                }

            }
        }
    }
}
                
                     
                      
                        

                    

                    
                
                
                

                






            













        
    

