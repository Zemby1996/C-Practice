namespace Interface
{
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();

    }

    public class Square : IShape
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }

        public double CalculatePerimeter()
        {
            return 4 * SideLength;
        }

    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius; ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape square = new Square(5);
            Console.WriteLine($"Square Area: {square.CalculateArea()}");
            Console.WriteLine($"Square Perimeter: {square.CalculatePerimeter()}");

            IShape circle = new Circle(3);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");
        }
    }
}