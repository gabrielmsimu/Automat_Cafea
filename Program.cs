using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Cafea
{
    class Program
    {
        static void Main(string[] args)
        {

            int suma_introdusa = 0; //stare
            int coin = 0;

            do
            {           
            
                Console.WriteLine("Please insert a coin");
                coin = int.Parse(Console.ReadLine());

                if (coin == 0)                 // Ca sa iesim din do - while apasam 0.
                {                             
                    break;                    
                }                             
                
                if (coin == 5) // in total avem 5 centi
                {
                    suma_introdusa += coin; //actualizam starea 
                    Console.WriteLine($"You need to insert {20-suma_introdusa} more cents"); // Spunem omului cat mai trebuie sa plateasca pentru produs
                    Console.WriteLine("Please insert a coin");                               // Omul insereaza moneda
                    coin = int.Parse(Console.ReadLine());                                    // Citim ce moneda a inserat

                    if (coin == 5) // in total avem 10 centi
                    {
                        suma_introdusa += coin; //actualizam starea 
                        Console.WriteLine($"You need to insert {20 - suma_introdusa} more cents");  // Spunem omului cat mai trebuie sa plateasca pentru produs
                        Console.WriteLine("Please insert a coin");                                  // Omul insereaza moneda
                        coin = int.Parse(Console.ReadLine());                                       // Citim ce moneda a inserat

                        if (coin == 5) // in total avem 15 centi
                        {
                            suma_introdusa += coin; //actualizam starea 
                            Console.WriteLine($"You need to insert {20 - suma_introdusa} more cents");
                            Console.WriteLine("Please insert a coin");
                            coin = int.Parse(Console.ReadLine());

                            if (coin == 5) // in total avem 20 de centi
                            {

                                Console.WriteLine("Thank you, here is your coffee.");
                                suma_introdusa = 0;  // actualizam starea la 0 pentru ca sa revenim la 0 centi in aparat pentru urmatorul client (ca sa mearga do-while-ul)
                                Console.ReadKey();
                            }
                            else if (coin == 10) // in total avem 25 de centi
                            {
                                suma_introdusa += coin; // actualizam starea
                                Console.WriteLine("Thank you, here is your coffee");
                                Console.WriteLine("Please remember to take your change");
                                Console.WriteLine($"Your change is {suma_introdusa - 20} cents (a nickel)");
                                suma_introdusa = 0; // actualizam starea la 0 pentru ca sa revenim la 0 centi in aparat pentru urmatorul client (ca sa mearga do-while-ul)
                                Console.ReadKey();
                            }
                            else if (coin == 25) // in total avem 40 de centi 
                            {
                                suma_introdusa += coin;
                                Console.WriteLine("Thank you, here is your coffee");
                                Console.WriteLine("Please remember to take your change");
                                Console.WriteLine($"Your change is {suma_introdusa - 20} cents (two dimes)");
                                suma_introdusa = 0; // actualizam starea la 0 pentru ca sa revenim la 0 centi in aparat pentru urmatorul client (ca sa mearga do-while-ul)
                                Console.ReadKey();

                            }
                        }
                        else if (coin == 10) // in total avem 20 de centi
                        {
                            Console.WriteLine("Thank you, here is your coffee");
                            suma_introdusa = 0;
                            Console.ReadKey();
                        }
                        else if (coin == 25) // in total avem 35 de centi
                        {
                            suma_introdusa += coin;
                            Console.WriteLine("Thank you, here is your coffee");
                            Console.WriteLine("Please remember to take your change");
                            Console.WriteLine($"Your change is {suma_introdusa - 20} cents (one dime and one nickel)");
                            suma_introdusa = 0;
                            Console.ReadKey();

                        }
                        

                    }
                    else if (coin == 10) // in total avem 15 centi
                    {
                        suma_introdusa += coin; //actualizam starea 
                        Console.WriteLine($"You need to insert {20 - suma_introdusa} more cents");  // Spunem omului cat mai trebuie sa plateasca pentru produs
                        Console.WriteLine("Please insert a coin");                                  // Omul insereaza moneda
                        coin = int.Parse(Console.ReadLine());                                       // Citim ce moneda a inserat

                        if (coin == 5) // avem 20 de centi
                        {
                            Console.WriteLine("Thank you, here is your coffee");
                            suma_introdusa = 0;
                            Console.ReadKey();
                        }
                        else if (coin == 10) // avem 25 de centi
                        {
                            suma_introdusa += coin; //actualizam starea
                            Console.WriteLine("Thank you, here is your coffee");
                            Console.WriteLine("Please remember to take your change");
                            Console.WriteLine($"Your change is {suma_introdusa - 20} cents (a nickel)");
                            suma_introdusa = 0;
                            Console.ReadKey();
                        }
                        else if (coin == 25) // avem 40 de centi
                        {
                            suma_introdusa += coin; //actualizam starea
                            Console.WriteLine("Thank you, here is your coffee");
                            Console.WriteLine("Please remember to take your change");
                            Console.WriteLine($"Your change is {suma_introdusa - 20} cents (two dimes)");
                            suma_introdusa = 0;
                            Console.ReadKey();
                        }


                    }
                    else if (coin == 25) // in total avem 30 de centi
                    {
                        suma_introdusa += coin; //actualizam starea
                        Console.WriteLine("Thank you, here is your coffee");
                        Console.WriteLine("Please remember to take your change");
                        Console.WriteLine($"Your change is {suma_introdusa - 20} cents (a dime)");
                        suma_introdusa = 0;
                        Console.ReadKey();
                    }

                
                }
                else if (coin == 10) // avem 10 centi
                {
                    suma_introdusa += coin;                                                     //actualizam starea 
                    Console.WriteLine($"You need to insert {20 - suma_introdusa} more cents");  // Spunem omului cat mai trebuie sa plateasca pentru produs
                    Console.WriteLine("Please insert a coin");                                  // Omul insereaza moneda
                    coin = int.Parse(Console.ReadLine());                                       // Citim ce moneda a inserat

                    if (coin == 5) //avem 15 centi
                    {
                        suma_introdusa += coin;
                        Console.WriteLine($"You need to insert {20 - suma_introdusa} more cents");
                        Console.WriteLine("Please insert a coin");
                        coin = int.Parse(Console.ReadLine());

                        if (coin == 5) //avem 20 de centi
                        {
                            Console.WriteLine("Thank you, here is your coffee");
                            suma_introdusa = 0;
                            Console.ReadKey();
                        }
                        else if (coin == 10) // avem 25 de centi
                        {
                            suma_introdusa += coin; //actualizam starea
                            Console.WriteLine("Thank you, here is your coffee");
                            Console.WriteLine("Please remember to take your change");
                            Console.WriteLine($"Your change is {suma_introdusa - 20} cents (a nickel)");
                            suma_introdusa = 0;
                            Console.ReadKey();
                        }
                        else if (coin == 25) // avem 40 de centi
                        {
                            suma_introdusa += coin; //actualizam starea
                            Console.WriteLine("Thank you, here is your coffee");
                            Console.WriteLine("Please remember to take your change");
                            Console.WriteLine($"Your change is {suma_introdusa - 20} cents (two dimes)");
                            suma_introdusa = 0;
                            Console.ReadKey();
                        }

                    }
                    else if (coin == 10) //avem 20 de centi
                    {
                        Console.WriteLine("Thank you, here is your coffee");
                        suma_introdusa = 0;
                        Console.ReadKey();
                    }
                    else if (coin == 25) //Avem 35 de centi
                    {
                        suma_introdusa += coin; //actualizam starea
                        Console.WriteLine("Thank you, here is your coffee");
                        Console.WriteLine("Please remember to take your change");
                        Console.WriteLine($"Your change is {suma_introdusa - 20} cents (a dime and a nickel)");
                        suma_introdusa = 0;
                        Console.ReadKey();
                    }
                    
                }
                else if (coin == 25)
                {
                    suma_introdusa += coin; //actualizam starea
                    Console.WriteLine("Thank you, here is your coffee");
                    Console.WriteLine("Please remember to take your change");
                    Console.WriteLine($"Your change is {suma_introdusa - 20} cents (a nickel)");
                    suma_introdusa = 0;
                    Console.ReadKey();
                }

                Console.Clear();
            } while (suma_introdusa == 0);

            
        }
    }
}
