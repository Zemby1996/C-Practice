namespace EvenNumberGenerator
{

    public class EvenNumberGenerator
    {
        public IEnumerable<int> GenerateEvenNumbers()
        {
            int number = 0;

            // Pętla generująca kolejne liczby parzyste
            while (true)
            {
                yield return number;  // Zwraca bieżącą liczbę parzystą
                number += 2;  // Przechodzi do następnej liczby parzystej
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var generator = new EvenNumberGenerator();
            var evenNumbers = generator.GenerateEvenNumbers();

            // Generowanie pierwszych 10 liczb parzystych
            int count = 0;
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
                count++;
                if (count == 10) break;  // Zatrzymujemy po wygenerowaniu 10 liczb
            }
        }
    }
}
