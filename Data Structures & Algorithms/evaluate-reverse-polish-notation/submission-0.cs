public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach (string s in tokens)
        {
            if (s == "+" || s=="-" || s=="/" || s== "*")
            {
                int b = stack.Pop();
                int a = stack.Pop();
                int result = 0;

                switch (s)
                {
                    case "+": 
                    result = a+b;
                    break;
                    case "-":
                    result = a - b;
                    break;
                    case "/":
                    result = a/b;
                    break;
                    case "*":
                    result = a*b;
                    break;
                } 
                stack.Push(result);
            } else {
                stack.Push(int.Parse(s));
            }
        }
        return stack.Peek();
    }
}