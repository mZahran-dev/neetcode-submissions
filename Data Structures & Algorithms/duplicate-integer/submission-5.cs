public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        // better solution is to use a hashset to store the numbers and check for duplicates in O(n) time complexity
        HashSet<int> seen = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.Contains(nums[i]))
                return true;

            seen.Add(nums[i]);
        }
        return false;
    }
}
