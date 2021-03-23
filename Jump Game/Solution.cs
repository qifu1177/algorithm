public class Solution
{
    public int Jump(int[] nums)
    {
        if (nums.Length < 2)
            return 0;
        return Jump(nums, 0);
    }
    private int Jump(int[] nums, int index)
    {
        int min = nums.Length;
        if (index + nums[index] >= nums.Length - 1)
            return 1;
        List<int> list = new List<int>();
        int maxStep = 0;
        int nextIndex = index + 1;
        for (int i = 1; i <= nums[index]; i++)
        {
            if (maxStep < index + i + nums[index + i])
            {
                maxStep = index + i + nums[index + i];
                nextIndex = index + i;
            }
        }
        min = 1 + Jump(nums, nextIndex);
        return min;
    }
}