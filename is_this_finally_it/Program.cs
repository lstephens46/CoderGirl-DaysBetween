using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            //string message = "Please enter a date in MM/DD/YYYY format:\t";

            string firstDateString = GetDate();     //message);
            string secondDateString = GetDate();    //message);

            DaysBetween(firstDateString, secondDateString);
            Console.ReadLine();
        }
//        You need to use an "if/else" - testing the two dates.

//You should subtract the newest date from the older date - so use your "if/else" to determine which is the oldest date - userDT1 or UserDT2.

//If userDT1 is older then - double daysBetween = (userDT2 - userDT1).TotalDays;

//        If userDT2 is older then - double daysBetween = (userDT2 - userD21).TotalDays;

//        Using this logic you will NOT get a negative value returned from your DaysBetween method.

//        Let me know if this works for you.

//        David Moeller   [7 days ago]
//Math.Abs will also do the trick.

        //call this method twice to get the dates
        public static string GetDate()          //String message)
        {
            Console.Write("Please enter a date in MM/DD/YYYY format:\t");
            string dateString = Console.ReadLine();
            return dateString;
        }
        // TODO: Create that has a method that counts the number of days between two different dates.

        public static double DaysBetween(string firstDate, string secondDate)
        {   //convert date string to DateTime object

            DateTime parsedFirstDate = DateTime.Parse(firstDate);
            DateTime parsedSecondDate = DateTime.Parse(secondDate);

            //TimeSpan daysBetweenConvert;
            //int daysBetween;

            if (parsedFirstDate > parsedSecondDate)
            {
                double daysBetween = (parsedFirstDate - parsedSecondDate).TotalDays;
                Console.WriteLine($"if {daysBetween}");
                return daysBetween;
            }
            else//(parsedSecondDate > parsedFirstDate)
            {
                double daysBetween = (parsedSecondDate - parsedFirstDate).TotalDays;
                Console.WriteLine($"Else {daysBetween}");
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
