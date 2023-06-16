namespace CSharpLeetCode;

public class LeftAndRightSumDifferenceSolution
{
    public int[] LeftRightDifference(int[] nums)
    {
        int leftSum = 0, rightSum = 0;
        rightSum = nums.Sum();
        for (int i = 0; i < nums.Length; i++)
        {
            var value = nums[i];
            rightSum -= value;
            nums[i] = Math.Abs(leftSum - rightSum);
            leftSum += value;
        }

        return nums;
    }
}