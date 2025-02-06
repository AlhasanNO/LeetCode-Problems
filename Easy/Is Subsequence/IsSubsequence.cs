public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrEmpty(s))
            return true;

        int first = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (s[first] == t[i])
                first++;

            if (first == s.Length)
                return true;
        }

        return false;
    }
}