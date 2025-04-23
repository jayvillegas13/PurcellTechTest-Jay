namespace MissingNumberApp
{
    // Interface to define the contract for finding missing numbers
    public interface INumberFinder
    {
        List<int> FindMissingNumbers(int[] nums);
    }
}
