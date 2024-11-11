namespace ParsingNegativeNumber
{
     internal class Program
    {

        static bool TryParseToNegativeInt(string input, out int result)
        {

            if (int.TryParse(input, out result))
            {
                if (result < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                result = default;
                return false;
            }

        }

        static void Main(string[] args)
        {

            int inputValue;

            while (!TryParseToNegativeInt(Console.ReadLine(), out inputValue))
            {
                Console.WriteLine("Insert negative number");
            }

            Console.WriteLine($"Inserted negative number = {inputValue}");

        }
    }
}
