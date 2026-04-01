public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char> map = new Dictionary<char,char> {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        Stack<char> stack = new Stack<char>();

        foreach (var c in s)
        {
            if (map.ContainsKey(c))
            {
                char topElement ='#';
                if (stack.Count > 0)
                {
                    topElement = stack.Pop();
                }
                else
                {
                    topElement ='#';
                }

                if (topElement != map[c]) return false;
            }
            else {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}
