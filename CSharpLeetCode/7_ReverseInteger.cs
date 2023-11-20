namespace CSharpLeetCode
{
    public class ReverseIntegerSolution
    {
        public int Reverse(int x)
        {
            var isNegative = x < 0;
            if (isNegative)
                x = -x;

            int result = 0;
            while (x > 0)
            {
                if (result > int.MaxValue / 10)
                    return 0;

                result = 10 * result + x % 10;

                x = x / 10;
            }

            if (isNegative)
                result = -result;

            return result;
        }
    }
}