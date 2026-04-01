public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var temp = target - nums[i];
            if (seen.ContainsKey(temp))
            {
                return new int[]{seen[temp],i};
            }
            seen[nums[i]] = i; 
        }
        return new int[0];
    }
}
