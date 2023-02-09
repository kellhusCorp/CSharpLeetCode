namespace CSharpLeetCode;

public class ShuffleStringSolution
{
    public string RestoreString(string s, int[] indices)
    {
        var chArray = s.ToCharArray();

        var result = new char[chArray.Length];

        for (var i = 0; i < chArray.Length; i++)
        {
            result[indices[i]] = chArray[i];
        }

        return new string(result);
    }
}