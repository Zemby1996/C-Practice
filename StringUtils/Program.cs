using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringUtils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reversedString = "I love c sharp";
            string countOccurences = "John likes John's father John son of John";
            string removeWhiteSpaces = "  There are      no white    spaces";

            Console.WriteLine(ReverseString(reversedString));
            Console.WriteLine(CountOccurrences(countOccurences, "ohn"));
            Console.WriteLine(RemoveWhitespace(removeWhiteSpaces));

        }

        static string ReverseString(string input)
        {
         
            StringBuilder sb = new StringBuilder();

            for ( int i = input.Length - 1; i >= 0; i-- )
            {
                sb.Append(input[i] );
            }
            return sb.ToString();



        }

        static int CountOccurrences(string input, string fragment)
        {
            int count = 0;
            int index = 0;

            while ((index = input.IndexOf(fragment, index)) != -1)
            {
                count++;
                index += fragment.Length;
            }
            return count;
                       

        }

        static string RemoveWhitespace(string input)
        {
          
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsWhiteSpace(input[i]))
                {
                    sb.Append(input[i]);
                }
            }

            return sb.ToString();
        }
    }
}
