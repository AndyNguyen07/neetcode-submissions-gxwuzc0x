public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] result = new int[n-k+1];
        int[] q  = new int[n];
        int head = 0, tail = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while (tail > head && nums[q[tail-1]] <= nums[i])
            {
                tail--;
            }
            q[tail] = i;
            tail++;
            if (q[head] < i - k + 1)
            {
                head++;
            }

            if (i >= k - 1)
            {
                result[i-k+1] = nums[q[head]];
            }
        }
        return result;
    }
}
