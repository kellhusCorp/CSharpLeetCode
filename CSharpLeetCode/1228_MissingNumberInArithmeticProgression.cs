namespace CSharpLeetCode
{
    public class MissingNumberInArithmeticProgressionSolution
    {
        public int MissingNumberLinearSearch(int[] arr)
        {
            if (arr[^1] == arr[0]) return arr[0];
            
            var d = (arr[^1] - arr[0]) / arr.Length;
            for(var i = 0; i <= arr.Length - 2; i++)
            {
                if (arr[i] + d != arr[i + 1])
                {
                    return arr[i] + d;
                }
            }

            return 0;
        }
    }
}