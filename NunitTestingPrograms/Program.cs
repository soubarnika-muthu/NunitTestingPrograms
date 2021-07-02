using System;

namespace NunitTestingPrograms
{
    class Program
    {
        // <summary>
        /// P1- Genrating changes for the given amount in vending machine
        /// </summary>
       
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to N Unit Testing Programs");
                Console.WriteLine("1 - Vending Machine");
                Console.WriteLine("Enter you choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.ReadInput();
                        break;

                    default:
                        break;
                }
                Console.Read();
            }
        }
    }

