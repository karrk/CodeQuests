public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

                foreach (var ch in s.ToCharArray())
                {
                    if (ch == '(')
                        stack.Push(')');
                    else if (ch == '{')
                        stack.Push('}');
                    else if (ch == '[')
                        stack.Push(']');
                    else if (stack.Count == 0 || stack.Pop() != ch)
                        return false;
                }
                return stack.Count == 0;
    }
}