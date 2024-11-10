namespace BMICalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");

            Console.WriteLine("Podaj swój wzrost (w metrach):");

            string heightString = Console.ReadLine();
            double height = double.Parse(heightString);

            Console.WriteLine("Podaj swoją wagę (w kg):");

            string massString = Console.ReadLine();
            double mass = double.Parse(massString);

            double BMI = mass / Math.Pow(height, 2);

            Console.WriteLine("Twój wskaźnik BMI to: " + BMI);

            if (BMI >= 35)
            {
                Console.WriteLine("Otyłość olbrzymia");
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("Otyłość");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("Nadwaga");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Waga normalna");
            }
            else
            {
                Console.WriteLine("Niedowaga");
            }
        }
    }
}