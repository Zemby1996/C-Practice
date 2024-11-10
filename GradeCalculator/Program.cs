namespace GradeCalculator
{
    public class GradeCalculator
    {
        public static string CalculatorGrade(double percentage)
        {
            if (percentage >= 90) 
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string result = GradeCalculator.CalculatorGrade(50);

            Console.WriteLine(result);

        }
    }


}
