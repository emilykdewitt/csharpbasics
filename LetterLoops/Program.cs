using System;
using System.Text;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or string of letters with no spaces");

            // Assigns the user's input in the console to the variable 'userInput'
            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                // Determines the number of times the character should be printed. First character -> printed 1 time
                int numTimesToPrint = i + 1;

                // Finds current character
                char currentCharacter = userInput[i];

                // Creates a StringBuilder whose first character is the current character
                var sb = new StringBuilder(currentCharacter, 255);

                // Adds an additional instance of the same character based on its index
                for (int x = 0; x < numTimesToPrint; x++)
                {
                    sb.Append(currentCharacter);
                }

                // Gets the string from StringBuilder
                string stringToCapitalize = sb.ToString();

                //Capitalizes the first letter in the string
                stringToCapitalize = char.ToUpper(stringToCapitalize[0]) + stringToCapitalize.Substring(1);

                // Writes the string to the console
                Console.WriteLine(stringToCapitalize);
            }

            Console.ReadLine();
        }
    }
}
