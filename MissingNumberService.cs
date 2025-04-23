namespace MissingNumberApp
{
   // A class to handle the user interaction and the algorithm execution
    public class MissingNumberService
    {
        private readonly INumberFinder _numberFinder;

        // Constructor to inject the dependency of the number finder
        public MissingNumberService(INumberFinder numberFinder)
        {
            _numberFinder = numberFinder;
        }

        // Method to display the missing numbers
        public void DisplayMissingNumber(int[] nums)
        {
            List<int> missingNumbers = _numberFinder.FindMissingNumbers(nums);

            // If there are missing numbers, display them
            if (missingNumbers.Count > 0)
            {
                Console.WriteLine("The missing numbers are: " + string.Join(", ", missingNumbers));
            }
            else
            {
                Console.WriteLine("No missing number.");
            }
        }
    }
}
