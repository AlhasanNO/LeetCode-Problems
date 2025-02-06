public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, char> sDic = new();
        Dictionary<char, char> tDic = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (sDic.ContainsKey(s[i]))
            {
                if (sDic[s[i]] != t[i])
                    return false;
            }

            else
                sDic[s[i]] = t[i];

            if (tDic.ContainsKey(t[i]))
            {
                if (tDic[t[i]] != s[i])
                    return false;
            }

            else
                tDic[t[i]] = s[i];
        }

        return true;
    }
}