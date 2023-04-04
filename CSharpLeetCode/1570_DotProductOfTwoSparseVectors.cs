namespace CSharpLeetCode;

public class SparseVector
{
    public Dictionary<int, int> Mapping;

    public SparseVector(int[] nums)
    {
        Mapping = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                Mapping[i] = nums[i];
            }
        }
    }

    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec)
    {
        var result = 0;
        foreach (var key in Mapping.Keys)
        {
            if (vec.Mapping.ContainsKey(key))
            {
                result += Mapping[key] * vec.Mapping[key];
            }
        }

        return result;
    }
}