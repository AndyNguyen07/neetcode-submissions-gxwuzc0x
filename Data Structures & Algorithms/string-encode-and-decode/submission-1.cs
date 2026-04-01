public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach (string s in strs)
        {
            sb.Append(s.Length.ToString());
            sb.Append('/');
            sb.Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            int j = s.IndexOf('/',i);
        int length = int.Parse(s.Substring(i, j - i));
        string str = s.Substring(j + 1, length);
        result.Add(str);

        i = j + 1 + length;
        }
        return result;
   }
}
