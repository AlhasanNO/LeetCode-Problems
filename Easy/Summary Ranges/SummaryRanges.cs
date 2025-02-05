public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        IList<string> result = [];

        if (nums == null || nums.Length == 0)
            return result;

        int start = nums[0];
        int end = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == end + 1)
                end = nums[i];

            else
            {
                if (start == end)
                    result.Add(start.ToString());

                else
                    result.Add($"{start}->{end}");

                start = nums[i];
                end = nums[i];
            }
        }

        if (start == end)
            result.Add(start.ToString());

        else
            result.Add($"{start}->{end}");

        return result;
    }
}