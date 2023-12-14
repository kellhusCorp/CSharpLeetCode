namespace CSharpLeetCode
{
    public class SecondContainsDuplicateSolution
    {
        public SecondContainsDuplicateSolution()
        {
            
        }   
        
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var d = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!d.ContainsKey(nums[i]))
                {
                    d.Add(nums[i], i);
                }
                else
                {
                    var j = d[nums[i]];
                    if (Math.Abs(i - j) <= k)
                    {
                        return true;
                    }

                    d[nums[i]] = i;
                }
            }

            return false;
        }
    }
}