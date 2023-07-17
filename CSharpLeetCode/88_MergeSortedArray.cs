namespace CSharpLeetCode;

public class MergeSortedArraySolution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var l = m - 1;
        var r = n - 1;

        for (int i = m + n - 1; i >= 0; i--)
        {
            if (r < 0)
            {
                break;
            }
            if (l >= 0 && nums1[l] > nums2[r])
            {
                nums1[i] = nums1[l--];
            }
            else
            {
                nums1[i] = nums2[r--];
            }
        }
    }
}