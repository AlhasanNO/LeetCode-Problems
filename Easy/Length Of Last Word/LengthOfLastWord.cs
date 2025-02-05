public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int length = 0;
        int n = s.Length - 1;

        while (n >= 0 && s[n] == ' ')
            n--;

        while (n >= 0 && s[n] != ' ')
        {
            length++;
            n--;
        }

        return length;
    }
}