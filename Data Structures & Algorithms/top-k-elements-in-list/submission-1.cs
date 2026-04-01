public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Mapping Frequency
        var count = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            count[num] = count.GetValueOrDefault(num, 0) + 1;
        }
        //Bucket Sort
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in count)
        {
            int frequency = pair.Value;
            if (buckets[frequency] == null)
            {
                buckets[frequency] = new List<int>();
            }
            buckets[frequency].Add(pair.Key);
        }

        var result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }
        return result.Take(k).ToArray();
    }
}