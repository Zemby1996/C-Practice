namespace TemperatureConverter
{

    public class TemperatureConverter
    {
        public void ConvertCelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = celsius * 1.8 + 32;
        }

        public void ConvertFahrenheitToCelsius(double fahrenheit, ref double celsius)
        {
            
            celsius = (fahrenheit - 32) / 1.8;

        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            TemperatureConverter converter = new TemperatureConverter();

            double tempC = 25;
            double tempF;

            converter.ConvertCelsiusToFahrenheit(tempC, out tempF);

            Console.WriteLine($"{tempC} Celsujsza równa się {tempF} Farenheita");

            double tempFa = 77;
            double tempCe = 0;

            converter.ConvertFahrenheitToCelsius(tempFa, ref tempCe);

            Console.WriteLine($"{tempFa} Farenheita równa się {tempCe} Celsujsza");

        }
    }
}
