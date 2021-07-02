using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestingPrograms
{
    class MonthlyPayment
    {
        public static void ReadInput()
        {
            Console.WriteLine("Welcome to Monthly Payment");
            //Reads inpt from user
            Console.Write("Enter Principle Amount: ");
            int principal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year to payoff:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the rate of Interest:");
            int rateOfInterest = Convert.ToInt32(Console.ReadLine());

            CalculatePayment(year, principal, rateOfInterest);

        }

        //calculating the monthly payment
        private static void CalculatePayment(int year, int principal, int r)
        {
            double payment;
            double roi = (double)r / (12 * 100);
            int n = 12 * year;

            //formula to calculate the monthly payment
            payment = (principal * roi) / (1 - (1 + r) ^ (-n));

            Console.WriteLine("Monthly Payment Amount:{0}", payment);
        }
    }
}

