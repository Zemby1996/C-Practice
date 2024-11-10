namespace TemperatureAnalyzer
{
   
    
    
    public class TemperatureAnalyzer
    {


        public static int FindHighestTemperature(int[] temperatures)
        {
            int highestTemperature = int.MinValue;

            foreach (int temp in temperatures)
            {
                if (temp > highestTemperature)
                {
                    highestTemperature = temp;
                }
            }
            return highestTemperature;
        }
        public static int FindLowestTemperature(int[] temperatures)
        {
            int lowestTemperature = int.MaxValue;

            foreach (int temp in temperatures)
            {
                if (temp < lowestTemperature)
                {
                   lowestTemperature = temp;
                }
            }
            return lowestTemperature;
        }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] tempArray = { 0, 1, 10, 16, 40, -20, 20, 11 };

            int lowest = TemperatureAnalyzer.FindLowestTemperature(tempArray);
            Console.WriteLine("Lowest temp: " +  lowest);

            int highest = TemperatureAnalyzer.FindHighestTemperature(tempArray);
            Console.WriteLine("Highest temp: " + highest);
        }
    }
}
