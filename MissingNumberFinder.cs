namespace MissingNumberApp
{
    public class MissingNumberFinder : INumberFinder
    {
        public List<int> FindMissingNumbers(int[] nums)
        {
            // Find the minimum and maximum numbers in the array
            int min = nums.Min();
            int max = nums.Max();

            // Use a HashSet for faster lookups
            HashSet<int> numSet = new HashSet<int>(nums);

            // List to hold the missing numbers
            List<int> missingNumbers = new List<int>();

            // Loop through the range from min to max
            for (int i = min; i <= max; i++)
            {
                // If the number i is not in the set, it's missing
                if (!numSet.Contains(i))
                {
                    missingNumbers.Add(i); // Add to missing numbers
                }
            }

            return missingNumbers; // Return the list of missing numbers
        }
    }
}
