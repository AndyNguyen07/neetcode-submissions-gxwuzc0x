public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix == null || matrix.Length == 0) return false;

        int m = matrix.Length; //Số Hàng
        int n = matrix[0].Length; //Số Cột

        int left = 0;
        int right = m * n - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int midValue = matrix[mid / n][mid % n];

            if (midValue == target)
            {
                return true;
            } else if (midValue < target)
            {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return false;
    }
}
