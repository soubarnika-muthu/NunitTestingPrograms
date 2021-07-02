using System;

namespace NunitTestingPrograms
{
	/// NUnit testing programs
	/// P1- Genrating changes for the given amount in vending machine
	/// P2- Computing the date to display the day using Gregorian calendar formula
	/// P3- Converts the temperature as celsius to fahrenheit and vice verse
	/// P4- Calculating the monthly payment 
	/// P5- Calculating square root of the number
	/// P6- Decimal to binary conversion
	/// p7- Swapping of binary bits 
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to N Unit Testing Programs");
			Console.WriteLine("1 - Vending Machine");
			Console.WriteLine("2 - Day of week");
			Console.WriteLine("3 - Temperature Conversion");
			Console.WriteLine("4 - Monthly Payment");
			Console.WriteLine("5 - Square Root");
			Console.WriteLine("6 - Decimal to binary Conversionit");
			Console.WriteLine("7 - Swapping of Binary value");
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

				case 3:
					TemperaturConversion temperaturConversion = new TemperaturConversion();
					temperaturConversion.ReadInput();
					break;

				case 4:
					MonthlyPayment.ReadInput();
					break;

				case 5:
					SquareRoot.ReadInput();
					break;

				case 6:
					DecimalToBinary decimalToBinary = new DecimalToBinary();
					decimalToBinary.ReadInput();
					break;

				case 7:
					BinarySwap.NibbleSwap();
					break;

				default:
					break;
			}
			Console.Read();
		}
	}
}





