using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestingPrograms
{
    class SquareRoot
    {
        const double EPSILON = 1e-15;
        public static void ReadInput()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            CalculateSqrt(number);

        }

        private static void CalculateSqrt(int num)
        {
            double temp = num;
            do
            {
                temp = (temp + (num / temp)) / 2;

            } while (Math.Abs(temp - num / temp) > (EPSILON * temp));

            Console.WriteLine("The square root of {0} is {1}", num, temp);
        }
    }
}
