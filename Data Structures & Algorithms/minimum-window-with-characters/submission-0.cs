public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length) return "";

        int[]  countT = new int[128];
        int[] window = new int[128];

        foreach (char c in t)
        {
            countT[c]++;
        }

        int have = 0;
        //Số lượng loại ký tự mà bạn đã thu thập đủ số lượng yêu cầu.
        int need = 0;
        //Số lượng loại ký tự độc nhất trong t. Ví dụ t = "AABC", các loại là A, B, C => need = 3.
        for (int i = 0; i < 128; i++)
        {
            if (countT[i] > 0)
            {
                need++;
            }
        }
        int left = 0;
        int minLen = 1001;
        int startIdx = -1;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            window[c]++;

            if (countT[c] > 0 && window[c] == countT[c])
            {
                have++;
            }
            while (have == need)
            {
                if (right - left + 1 < minLen)
                {
                    minLen = right - left + 1;
                    startIdx = left;
                }

                // Thu hẹp bên trái để tìm chuỗi ngắn hơn
                char leftChar = s[left];
                window[leftChar]--;
                if (countT[leftChar] > 0 && window[leftChar] < countT[leftChar])
                {
                    have--;
                }
                left++;
            }
        }
        return startIdx == -1 ? "" : s.Substring(startIdx, minLen);
    }
}
