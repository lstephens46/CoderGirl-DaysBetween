using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            string message = "Please enter a date in MM/DD/YYYY format:\t";
            Console.WriteLine(message);
            string firstDateString = Console.ReadLine();

            Console.WriteLine(message);
            string secondDateString = Console.ReadLine();

            //string firstDateString = GetDate();     //message);
            //string secondDateString = GetDate();    //message);

            DaysBetween(firstDateString, secondDateString);
            Console.ReadLine();
        }


        //call this method twice to get the dates
        //public static string GetDate()          //String message)
        //{
        //    Console.Write("Please enter a date in MM/DD/YYYY format:\t");
        //    string dateString = Console.ReadLine();
        //    return dateString;
        //}
        // TODO: Create that has a method that counts the number of days between two different dates.

        public static int DaysBetween(string firstDate, string secondDate)
        {   //convert date string to DateTime object

            DateTime parsedFirstDate = DateTime.Parse(firstDate);
            DateTime parsedSecondDate = DateTime.Parse(secondDate);

            TimeSpan daysBetweenConvert;
            //int daysBetween;

            if (parsedFirstDate > parsedSecondDate)
            {
                //daysBetweenConvert = parsedFirstDate.Subtract(parsedSecondDate);
                daysBetweenConvert = parsedFirstDate - parsedSecondDate;
                Console.WriteLine($"this is the if {daysBetweenConvert.Days}");
                //daysBetween = daysBetweenConvert.Days;
                return daysBetweenConvert.Days;
            }
            else//(parsedSecondDate > parsedFirstDate)
            {
                daysBetweenConvert = parsedSecondDate - parsedFirstDate;
                Console.WriteLine($"this is the else {daysBetweenConvert.Days}");
                //daysBetween = daysBetweenConvert.Days;
                return daysBetweenConvert.Days;

            }
            //else
            //{   
            //    Console.WriteLine("You did not enter a valid date");
            //    return;
            //}

        }
    }
}
