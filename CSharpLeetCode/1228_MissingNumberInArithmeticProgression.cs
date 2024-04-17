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

        public int MissingNumberBinarySearch(int[] arr)
        {
            var d = (arr[^1] - arr[0]) / arr.Length;
            var left = 0;
            var right = arr.Length - 1;
            while (left < right)
            {
                var middle = left + (right - left) / 2;
                if (arr[middle] == arr[0] + d * middle)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            return arr[0] + d * left;
        }
    }
}