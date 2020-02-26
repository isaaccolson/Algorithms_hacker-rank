public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> combinedArray = nums1.ToList();
        combinedArray.AddRange(nums2.ToList());

        combinedArray.Sort();
        var count = combinedArray.Count;

        var index = count / 2;

        if (count % 2 != 0)
        {
            return combinedArray[index];
        }
        else
        {

            return (combinedArray[index] + combinedArray[index - 1]) / 2.0; //need to divide by 2.0 for the double
        }

    }

}
