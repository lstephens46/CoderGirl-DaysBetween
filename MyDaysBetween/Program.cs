using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            Console.WriteLine("\tDays Between Two Dates\t");

            //string firstDateString = GetDate();
            //string secondDateString = GetDate();

            DaysBetween(GetDate(), GetDate());
            Console.ReadLine();
        }


        //call this method twice to get the dates
        public static string GetDate()
        {
            Console.Write("Please enter a date in MM/DD/YYYY format:\t");
            string dateString = Console.ReadLine();
            return dateString;
        }
        // TODO: Create that has a method that counts the number of days between two different dates.

        public static TimeSpan DaysBetween(string firstDate, string secondDate)
        {   //convert date string to DateTime object

            DateTime parsedFirstDate = DateTime.Parse(firstDate);
            DateTime parsedSecondDate = DateTime.Parse(secondDate);

            //TimeSpan daysBetween;
            DateTime daysBetween;

            if (parsedFirstDate > parsedSecondDate)
            {
                daysBetween = parsedFirstDate.Subtract(parsedSecondDate).Days;
                Console.WriteLine($"this is the if{daysBetween}");
                return daysBetween;
            }
            else//(parsedSecondDate > parsedFirstDate)
            {
                daysBetween = parsedSecondDate.Subtract(parsedFirstDate);
                Console.WriteLine($"this is the else {daysBetween}");
                return daysBetween;

            }
            //else
            //{   
            //    Console.WriteLine("You did not enter a valid date");
            //    return;
            //}

        }
    }
}
