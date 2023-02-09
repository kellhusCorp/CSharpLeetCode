namespace CSharpLeetCode;

public class MajorityElementSolution 
{
    public int MajorityElement(int[] nums)
    {
        var majorElement = nums[0];
        var counter = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            if (counter == 0)
            {
                majorElement = nums[i];
                counter++;
            }
            else
            {
                if (nums[i] == majorElement) counter++;
                else counter--;
            }
        }

        return majorElement;
    }
}