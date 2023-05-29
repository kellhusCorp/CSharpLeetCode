namespace CSharpLeetCode;

public class ConfusingNumberSolution
{
    private static IDictionary<int, int> _mapping = new Dictionary<int, int>
    {
        [0] = 0,
        [1] = 1,
        [6] = 9,
        [8] = 8,
        [9] = 6
    };

    public bool ConfusingNumber(int n)
    {
        var copy = n;
        var rotated = 0;
        while (copy > 0)
        {
            var digit = copy % 10;
            if (!_mapping.ContainsKey(digit))
            {
                return false;
            }

            rotated = rotated * 10 + _mapping[digit];
            copy /= 10;
        }

        return rotated != n;
    }
}