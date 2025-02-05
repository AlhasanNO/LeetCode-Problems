public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new();

        for (int i = 0; i < s.Length; i++)
        {
            char current = s[i];

            if ((current == '(') ||
                (current == '[') ||
                (current == '{'))
            {
                stack.Push(current);
            }

            else
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();

                if (!((top == '(' && current == ')') ||
                      (top == '[' && current == ']') ||
                      (top == '{' && current == '}')))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}