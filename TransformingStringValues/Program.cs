using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace TransformingStringValues
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            

            Console.WriteLine("User input:");
            
            string kebabCased = "this-is-some-variable";
            string camelCased = "thisIsSomeVariable";

            Console.WriteLine(KebabToCamelCase(kebabCased));
            Console.WriteLine(CamelToKebabCase(camelCased));


            
            //CamelToKebab(userInput);
            //thisIsSomeVariable
            //KebabToCamel(userInput);
            //this-is-some-variable


        }
        

        static string KebabToCamelCase(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar != '-') 
                { 
                    sb.Append(currentChar);
                }
                else
                {
                    char nextChar = input[i + 1];

                    sb.Append(char.ToUpper(nextChar));

                    i++;
                }
            }

            return sb.ToString();
        }

        static string CamelToKebabCase(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char currentChar in input)
            {
                if (char.IsUpper(currentChar))
                {
                    sb.Append("-");
                    sb.Append(char.ToLower(currentChar));
                }
                else
                {
                    sb.Append(currentChar);
                }
            }

            return sb.ToString();


        }
        
        //static void CamelToKebab(string userInput)
        //{

        //    string[] dividedWords = SplitCamelCase(userInput);
        //    string kebabCase = string.Join("-", dividedWords).ToLower();


        //    Console.WriteLine(kebabCase);  


        //    static string[] SplitCamelCase(string input)
        //    {
        //        return Regex.Split(input, "(?<!^)(?=[A-Z])");
        //    }

        //}


        //static void KebabToCamel(string userInput)
        //{
        //    string removeDash = userInput.Replace("-", " ");
        //    TextInfo textinfo = CultureInfo.CurrentCulture.TextInfo;
        //    string upperCase = textinfo.ToTitleCase(removeDash.ToLower());
        //    string camelCase = char.ToLower(upperCase[0]) + upperCase.Substring(1).Replace(" ", "");

        //    Console.WriteLine(camelCase);
        //}
    }
}