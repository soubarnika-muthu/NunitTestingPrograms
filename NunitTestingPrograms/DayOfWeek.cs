using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestingPrograms
{
    class DayOfWeek
    {
        //constant array for week
        private readonly string[] WEEK = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        public void ReadInput()
        {
            Console.WriteLine("Welcome to Day of week");

            //get input from the user and month , day and year
            Console.WriteLine("enter the date:");
            Console.Write("month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("day:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("year:");
            int year = Convert.ToInt32(Console.ReadLine());

            //calling the method
            int dayOfWeek = FindDayOfWeek(day, month, year);

            //printing the result
            Console.WriteLine("{0}/{1}/{2} is {3}", day, month, year, WEEK[dayOfWeek]);
        }

        private int FindDayOfWeek(int dd, int mm, int yy)
        {
            //temp local variables
            int temp;
            int y0, m0, week;

            //formula for Gregorian calendar 
            y0 = yy - (14 - mm) / 12;
            temp = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = mm + 12 * ((14 - mm) / 12) - 2;
            week = (dd + temp + 31 * m0 / 12) % 7;

            return week;
        }


    }
}