using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestingPrograms
{
    //inherit the decimal to binay class
    class BinarySwap : DecimalToBinary
    {
        public static void NibbleSwap()
        {
            DecimalToBinary decimalToBinary = new DecimalToBinary();
            Console.WriteLine("Decimal to Binary bit swapping");
            //Reads input from user
            Console.WriteLine("Enter the decimal number:");
            int deci = Convert.ToInt32(Console.ReadLine());

            //method in decimal to binary class
            int binaryValue = decimalToBinary.DecToBin(deci);

            //calling swapping function
            int afterSwap = Swap(deci);
            int binAfter = decimalToBinary.DecToBin(afterSwap);

            Console.WriteLine("Before swapping");
            Console.WriteLine("The binary value of {0} is : {1}\n \n", deci, binaryValue);
            Console.WriteLine("After swapping");
            Console.WriteLine("The binary value of {0} is : {1}", afterSwap, binAfter);


        }

        //method to swap nibbles
        private static int Swap(int n)
        {
            int afterSwap = (n & 0x0F) << 4 | (n & 0xF0) >> 4;
            return afterSwap;

        }

    }
}