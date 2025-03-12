using System.Diagnostics;
using System.Text;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTimeModification();
            //DateTimeFormatting();
            //TimeMeasurement();
            DateTimeHelper();

        }

        static void DateTimeModification()
        {
            DateTime now = DateTime.Now;
            DateTime openDate = new DateTime(1992, 6, 17);

            TimeSpan result = now - openDate;

            Console.WriteLine(result.Days);
            Console.WriteLine(result.TotalDays);

            DateTime expiresAt = now.AddDays(7);
            DateTime expiresAt2 = now.Add(new TimeSpan(7, 1, 0, 0));

            Console.WriteLine(expiresAt);
            Console.WriteLine(expiresAt2);

            bool expiresAtTheSameDay = expiresAt.Date == expiresAt2.Date;

            Console.WriteLine(expiresAtTheSameDay);
        }

        static void DateTimeFormatting() 
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("g"));
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss"));
        }

        static void TimeMeasurement() 
        {
            Console.WriteLine("What is 2+2");
            Console.WriteLine("A)4");
            Console.WriteLine("B)6");
            Console.WriteLine("C)8");

            DateTime start = DateTime.Now;

            Stopwatch stopwatch = Stopwatch.StartNew();
            

            string userAnswer = Console.ReadLine();

            stopwatch.Stop();

            DateTime end = DateTime.Now;

            TimeSpan responseTime = end - start;

            Console.WriteLine($"Response took you: {responseTime.TotalSeconds} seconds");
            Console.WriteLine($"Response took you: {stopwatch.Elapsed.TotalSeconds} seconds");
        }

        static void DateTimeHelper()
        {

            int daysInFeb2025 = DateTime.DaysInMonth(2025, 2);
            bool isLeapYear = DateTime.IsLeapYear(2025);

            Console.WriteLine($"daysInFeb2025: {daysInFeb2025}");
            Console.WriteLine($"is2025LeapYear: {isLeapYear}");

            
          

        }

       
    }
}
