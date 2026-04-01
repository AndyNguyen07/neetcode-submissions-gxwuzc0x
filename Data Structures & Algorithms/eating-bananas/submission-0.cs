public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = 0;
        foreach (var p in piles) if (p > right) right = p;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (CanFinish(piles, h , mid))
            {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        return left;
    }

    private bool CanFinish(int[] piles, int h, int k)
    {
        long totalHours = 0;
        foreach (var p in piles)
        {
            totalHours += (p + k - 1) / k;
        }
        return totalHours <= h;
    }
}
