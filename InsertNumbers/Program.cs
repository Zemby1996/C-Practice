using System.Diagnostics.CodeAnalysis;

namespace InsertNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int suma = 0;

            int n;

            int highestNumber = int.MinValue;

            do
            {
                Console.Write("Podaj liczbę: ");
                n = Convert.ToInt32(Console.ReadLine());
                {
                    suma += n;

                    if (n > highestNumber)
                    {
                        highestNumber = n;
                    }
                }
            }
            while (n != 0);

            Console.WriteLine("Suma wszystkich elementów: " + suma);
            Console.WriteLine("Największy element: " + highestNumber);
        }
    }
}
/*Console.WriteLine("Insert numbers: ");

int userInput = int.Parse(Console.ReadLine());

int sum = 0;

int? maxValue = null;

while (userInput != 0)
{
    if (maxValue == null || userInput > maxValue)
    {
        maxValue = userInput;
    }
    sum += userInput;

    userInput = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Sum of numbers = {sum}");
Console.WriteLine($"Max value = {maxValue}");
*/

