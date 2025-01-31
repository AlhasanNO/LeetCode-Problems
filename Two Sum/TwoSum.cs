public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int x;
        Dictionary<int, int> keyValuePairs = new();

        for (int i = 0; i < nums.Length; i++)
        {
            x = target - nums[i];

            if (keyValuePairs.ContainsKey(x))
            {
                return [keyValuePairs[x], i];
            }

            keyValuePairs[nums[i]] = i;
        }

        return [];
    }
}