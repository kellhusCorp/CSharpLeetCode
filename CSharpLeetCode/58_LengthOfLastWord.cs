namespace CSharpLeetCode
{
    public class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s)
        {
            var length = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && length > 0)
                {
                    break;
                }

                if (s[i] != ' ')
                {
                    length++;
                }
            }

            return length;
        }
    }
}