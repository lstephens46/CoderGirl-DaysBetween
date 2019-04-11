using System;
using System.Transactions;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            Console.WriteLine("Please enter a date in dd/mm/yyyy format");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a date in dd/mm/yyyy format");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            DaysBetween(firstDate, secondDate);
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

      
        // TODO: Create that has a method that counts the number of days between two different dates.

        public static double DaysBetween(DateTime firstDate, DateTime secondDate)
        {   

            if (firstDate > secondDate)
            {
                double daysBetween = (firstDate - secondDate).Days;
                Console.WriteLine($"if {daysBetween}");
                return daysBetween;
            }
            else
            {
                double daysBetween = (secondDate - firstDate).Days;
                Console.WriteLine($"Else {daysBetween}");
                return daysBetween;
            }
            

        }
    }
}
