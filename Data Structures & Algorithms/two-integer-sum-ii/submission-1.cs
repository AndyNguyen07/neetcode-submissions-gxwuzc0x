public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int L = 0;
        int R = numbers.Length - 1;
        while (R > L)
        {
            int currentSum = numbers[L] + numbers[R];

            if (currentSum == target) return new int[]{L + 1, R + 1};
            else if (currentSum > target)
            {
                R--;
            }
            else 
            {
                L++;
            }
        }
        return new int[]{};
    }
}
