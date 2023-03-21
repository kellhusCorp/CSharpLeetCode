namespace CSharpLeetCode;

public class CountNumberOfPairsSolution 
{
    public int CountKDifference(int[] nums, int k)
    {
        short counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) == k)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}