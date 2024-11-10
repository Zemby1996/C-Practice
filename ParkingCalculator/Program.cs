namespace ParkingCalculator
{

    public class ParkingCalculator
    {
        public static double CalculateParkingFee(int hours)
        {
            double result = 0;

            switch (hours)
            {
                case 0:
                    result = 0;
                    break;

                case 1:
                    result = 5;
                    break;

                default:
                    result = 5 + (hours - 1) * 3;
                    break;


            }
            return result;

        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            double fee = ParkingCalculator.CalculateParkingFee(3);

            Console.WriteLine(fee);
        }
    }
}
