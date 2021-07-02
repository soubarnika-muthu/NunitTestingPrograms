using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestingPrograms
{
    class DecimalToBinary
    {
        public void ReadInput()
        {
            DecimalToBinary decimalToBinary = new DecimalToBinary();
            Console.WriteLine("Decimal to Binary Convertion");
            //Reads input from user
            Console.WriteLine("Enter the decimal number:");
            int deci = Convert.ToInt32(Console.ReadLine());
            //calling the coversion method
            int binary = decimalToBinary.DecToBin(deci);
            Console.WriteLine("The binary value of {0} is : {1}", deci, binary);

        }
        public int DecToBin(int dec)
        {
            int binaryNum = 0;
            int remainder, place = 1;

            //repeat till decimal reaches 0
            while (dec != 0)
            {
                //takes remainder when number is divided by 2
                remainder = dec % 2;

                //replace decimal value by quotient when divided by 2
                dec /= 2;

                //append the value in next place
                binaryNum += remainder * place;

                //increament the place value 
                place *= 10;
            }
            return binaryNum;
        }
    }
}