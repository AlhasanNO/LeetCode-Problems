public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int element = nums[0];
        int counter = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == element)
                counter++;

            else
                counter--;

            if (counter == 0)
            {
                element = nums[i];
                counter = 1;
            }
        }

        return element;
    }
}