using System.Diagnostics;

namespace DaysSinceBirth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the day of birth");

            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert the month of birth");

            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert the year of birth");

            int year = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);

            DateTime currentDate = DateTime.Now; 

            TimeSpan diffOfDates = currentDate - birthDate;

            Console.WriteLine("Difference in days: " + diffOfDates.Days);
                    
        
        }
    }
}
