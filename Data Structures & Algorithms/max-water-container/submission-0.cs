public class Solution {
    public int MaxArea(int[] heights) {
        int L = 0;
        int R = heights.Length - 1;
        int maxArea = 0;

        while (L < R) {
            int width = R - L;
            int h = Math.Min(heights[L], heights[R]);
            
            int currentArea = width * h;
            maxArea = Math.Max(maxArea, currentArea);

            if (heights[L] < heights[R]) {
                L++;
            } else {
                R--;
            }
        }

        return maxArea;
    }
}
