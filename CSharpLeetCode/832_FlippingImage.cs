namespace CSharpLeetCode;

public class FlippingImageSolution
{
    private readonly Func<int[], int[]> _flipAction;

    public FlippingImageSolution()
    {
        _flipAction += HorizontallyFlipRow;
        _flipAction += InvertRow;
    }

    public int[][] FlipAndInvertImage(int[][] image)
    {
        for (var i = 0; i < image.Length; i++)
        {
            image[i] = FlipAndInvertRow(image[i]);
        }

        return image;
    }

    public int[] FlipAndInvertRow(int[] row)
    {
        return _flipAction(row);
    }

    public int[] HorizontallyFlipRow(int[] row)
    {
        for (int i = 0, j = row.Length - 1; j > i; i++, j--)
        {
            (row[i], row[j]) = (row[j], row[i]);
        }

        return row;
    }

    public int[] InvertRow(int[] row)
    {
        for (var i = 0; i < row.Length; i++)
        {
            row[i] = row[i] == 0 ? 1 : 0;
        }

        return row;
    }
}