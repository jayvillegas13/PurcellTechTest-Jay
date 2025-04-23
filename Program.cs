using System;

namespace MissingNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input an array in the format "[3, 0, 1]"
            Console.WriteLine("Enter the numbers in the format [3, 0, 1]:");
            string input = Console.ReadLine();

            // Remove the brackets and split the string by commas
            string[] numberStrings = input.Trim('[', ']').Split(',');

            // Convert the string array into an integer array
            int[] nums = numberStrings.Select(str => int.Parse(str.Trim())).ToArray();

            // Create an instance of MissingNumberFinder
            var numberFinder = new MissingNumberFinder();
            var service = new MissingNumberService(numberFinder);

            // Display the missing number or "No missing number" if the array is complete
            service.DisplayMissingNumber(nums);
        }
    }
}
