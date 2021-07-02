using System;

namespace NunitTestingPrograms
{
    class Program
    {
        /// P1- Genrating changes for the given amount in vending machine
        /// P2- Computing the date to display the day using Gregorian calendar formula
        /// </summary>
       
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to N Unit Testing Programs");
                Console.WriteLine("1 - Vending Machine");
                Console.WriteLine("2 - Day of week");
                Console.WriteLine("Enter you choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.ReadInput();
                        break;

                    case 2:
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.ReadInput();
                        break;

                    default:
                        break;
                }
                Console.Read();
            }
        }
    }
