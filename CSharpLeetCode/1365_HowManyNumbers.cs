namespace CSharpLeetCode;

public class HowManyNumbersSolution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var sortedArray = nums.OrderBy(x => x).ToArray();

        var mapper = new Dictionary<int, int>();

        var result = new int[nums.Length];

        for (int i = 0; i < sortedArray.Length; i++)
        {
            if (!mapper.ContainsKey(sortedArray[i]))
            {
                mapper[sortedArray[i]] = i;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = mapper[nums[i]];
        }
        
        return result;
    }
}