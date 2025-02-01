public class Solution
{
    public int MajorityElement(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int counter = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                    counter++;
            }

            if (counter > nums.Length / 2)
                return nums[i];
        }

        return 0;
    }
}