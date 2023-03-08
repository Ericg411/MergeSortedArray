namespace MergeSortedArray;
public class Class1
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        List<int> list = new List<int>();
        int sum = m + n;
        int secondIndex = 0;
        for (int i = m; i <= sum - 1; i++)
        {
            nums1[i] = nums2[secondIndex];
            secondIndex++;
            if (secondIndex == n)
            {
                break;
            }
        }

        Array.Sort(nums1);

    }
}
