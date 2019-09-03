using System;

namespace Number_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a list of numbers separated by commas");

            var userInput = Console.ReadLine();

            var arrayOfNumsInStringForm = userInput.Split(",");

            int[] arrayOfInts = Array.ConvertAll(arrayOfNumsInStringForm, int.Parse);

            Console.WriteLine("Type 'multiply' to multiply all numbers. Type 'square' to get the square of each number.");

            var userChoice = Console.ReadLine();

            if (userChoice == "multiply")
            {
                int total = 1;

                for (int i = 0; i < arrayOfInts.Length; i++)
                {
                    total *= arrayOfInts[i];
                }

                Console.WriteLine($"All of these numbers multiplied together equals {total}");
            }
            else if (userChoice == "square")
            {
                for (int i = 0; i < arrayOfInts.Length; i++)
                {
                    int squaredResult = arrayOfInts[i] * arrayOfInts[i];
                    Console.WriteLine($"The square of {arrayOfInts[i]} is {squaredResult}");
                }
            }

            Console.ReadLine();
        }
    }
}
