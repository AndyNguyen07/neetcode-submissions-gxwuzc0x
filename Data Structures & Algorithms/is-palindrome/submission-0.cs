public class Solution {
    public bool IsPalindrome(string s) {
        int L = 0;
        int R = s.Length - 1;

        while (L < R) {
            // 1. Skip ký tự bên trái nếu không phải chữ/số
            if (!char.IsLetterOrDigit(s[L])) {
                L++;
            } 
            // 2. Skip ký tự bên phải nếu không phải chữ/số
            else if (!char.IsLetterOrDigit(s[R])) {
                R--;
            } 
            // 3. Khi cả 2 đều hợp lệ, tiến hành so sánh
            else {
                if (char.ToLower(s[L]) != char.ToLower(s[R])) {
                    return false;
                }
                L++;
                R--;
            }
        }
        return true;
    }
}
