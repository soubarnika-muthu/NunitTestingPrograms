using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestingPrograms
{
    class VendingMachine
    {
        public readonly int[] NOTES = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
        public void ReadInput()
        {
            Console.WriteLine("Welcome to Vending Machine");
            Console.WriteLine("Enter the Amount Given:");
            //reading input from the user
            int amount = Convert.ToInt32(Console.ReadLine());
            GeneratinBalance(amount);
        }

        //method for generating the change
        private void GeneratinBalance(int amt)
        {

            int[] noteCounter = new int[NOTES.Length];
            int numberOfNotes = 0;

            for (int iter = 0; iter < NOTES.Length; iter++)
            {
                //checking whether the amount is greater than current change
                if (amt >= NOTES[iter])
                {
                    noteCounter[iter] = amt / NOTES[iter];
                    amt -= NOTES[iter] * noteCounter[iter];  // store the balance amount after the change
                    numberOfNotes += noteCounter[iter];
                    // if amount becomes 0 then exit the loop
                    if (amt < 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Minimum number of notes :" + numberOfNotes);
            //printing the changes
            for (int iter = 0; iter < NOTES.Length; iter++)
            {
                if (noteCounter[iter] != 0)
                {
                    Console.WriteLine("{0} of {1}", noteCounter[iter], NOTES[iter]);
                }
            }


        }
    }
}
