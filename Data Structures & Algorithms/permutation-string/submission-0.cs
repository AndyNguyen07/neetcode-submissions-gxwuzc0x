public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        int[] countS1 = new int[26];
        int[] countS2 = new int[26];
        
        for (int i = 0; i < s1.Length; i++)
        {
            countS1[s1[i] - 'a']++;
            countS2[s2[i] - 'a']++;
        }

        for (int i = 0; i < s2.Length - s1.Length; i++)
        {
            if (Matches(countS1,countS2)) return true;
            countS2[s2[i + s1.Length] - 'a']++;
            countS2[s2[i] - 'a']--;
        }
        return Matches(countS1, countS2);
    }

    private bool Matches (int[] c1, int[] c2)
    {
        for (int i = 0; i < 26 ; i++)
        {
            if (c1[i] != c2[i]) return false;
        }
        return true;
    }
}
