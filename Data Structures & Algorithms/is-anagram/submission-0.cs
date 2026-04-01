public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> counts = new Dictionary<char, int>();
        foreach (var c in s)
        {
            counts[c]= counts.GetValueOrDefault(c, 0) + 1;
        }

        foreach (var c in t)
        {
            if (!counts.ContainsKey(c) || counts[c] == 0) return false;
            counts[c]-- ;
        }
        return true ;

    }
}
