public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length == 0) return 0;
        int L = 0, R = height.Length - 1;
        int leftMax = height[L];
        int rightMax = height[R];
        int totalWater = 0;

        while (L < R) {
            // So sánh xem bên nào đang thấp hơn để xử lý bên đó trước
            if (leftMax < rightMax) {
                L++;
                leftMax = Math.Max(leftMax, height[L]);
                totalWater += leftMax - height[L];
            } else {
                R--;
                rightMax = Math.Max(rightMax, height[R]);
                totalWater += rightMax - height[R];
            }
        }

        return totalWater;
    }
}
