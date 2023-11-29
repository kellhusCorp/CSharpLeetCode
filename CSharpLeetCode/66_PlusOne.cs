namespace CSharpLeetCode
{
    public class PlusOneSoltuion
    {
        public int[] PlusOne(int[] digits) 
        {
            int carry = 1;
            for(int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += carry;
                if(digits[i] > 9)
                {
                    digits[i] = 0;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                    break;
                }
            }
            if (carry == 1)
            {
                int[] result = new int[digits.Length + 1];
                result[0] = 1;
                for(int i = 0; i < digits.Length; i++)
                {
                    result[i + 1] = digits[i];
                }
                return result;
            }
            return digits;
        }
    }
}