namespace Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vehicle car = new Car("Tesla Model S");
            car.Start();
            car.Stop();

            Vehicle motorcycle = new Motorcycle("Harley-Davidson");
            motorcycle.Start();
            motorcycle.Stop();
        }
    }
}