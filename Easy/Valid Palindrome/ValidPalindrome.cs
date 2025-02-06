public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s == " ")
            return true;

        int first = 0;
        int last = s.Length - 1;

        while (last >= first)
        {
            while (first < last && !char.IsLetterOrDigit(s[first]))
                first++;

            while (first < last && !char.IsLetterOrDigit(s[last]))
                last--;

            if (char.ToLower(s[first]) != char.ToLower(s[last]))
                return false;

            first++;
            last--;
        }

        return true;
    }
}