using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestingPrograms
{
    class TemperaturConversion
    {
        public void ReadInput()
        {
            Console.WriteLine("Welcome to temperature conversion");

            //choose which type convertion should carried out
            Console.WriteLine("Enter user option:");
            Console.WriteLine("1-Celsius to Fahrenheit:");
            Console.WriteLine("2-Fahrenheit to Celsius:");
            int choice = Convert.ToInt32(Console.ReadLine());
            BeginConversion(choice);

        }

        //method converts celsius to fahrenheit
        private void CelsiusToFahrenheit(int cel)
        {
            int fahren;
            fahren = (cel * 9 / 5) + 32;
            Console.WriteLine("{0} degree Celsius = {1} degree Fahrenheit", cel, fahren);

        }

        //converts fahrenheit to celsius
        private void FahrenheitToCelsius(int faren)
        {
            int cel;
            cel = (faren - 32) * 5 / 9;
            Console.WriteLine("{0} degree Fahrenheit = {1} degree Celsius", faren, cel);

        }

        //select which convertion to be executed
        private void BeginConversion(int choice)
        {
            int temperature;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the degree in celsius: ");
                    temperature = Convert.ToInt32(Console.ReadLine());
                    CelsiusToFahrenheit(temperature);
                    break;

                case 2:
                    Console.WriteLine("Enter the degree in Fahrenheit: ");
                    temperature = Convert.ToInt32(Console.ReadLine());
                    FahrenheitToCelsius(temperature);
                    break;

                default:
                    break;
            }
        }
    }
}