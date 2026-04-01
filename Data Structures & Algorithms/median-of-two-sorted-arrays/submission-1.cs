public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) return FindMedianSortedArrays(nums2,nums1);
        int m = nums1.Length;
        int n = nums2.Length;

        int left = 0, right = m;

        while (left <= right)
        {
            int i = left + (right - left) / 2;
            int j = (m + n + 1) / 2 - i;

            int L1 = (i == 0) ? int.MinValue : nums1[i - 1];
            int R1 = (i == m) ? int.MaxValue : nums1[i];
            int L2 = (j == 0) ? int.MinValue : nums2[j - 1];
            int R2 = (j == n) ? int.MaxValue : nums2[j];

            if (L1 <= R2 && L2 <= R1)
            {
                if ((m + n) % 2 == 1)
                {
                    return Math.Max(L1,L2);
                }
                return (Math.Max(L1,L2) + Math.Min(R1,R2)) / 2.0;
            }
            else if (L1 > R2)
            {
                right = i - 1;
            } else {
                left = i + 1;
            }
        }
        return 0.0;
    }
}
